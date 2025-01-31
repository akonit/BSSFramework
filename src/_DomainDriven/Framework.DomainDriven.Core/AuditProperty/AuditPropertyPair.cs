﻿using System.Collections;
using System.Linq.Expressions;

using Framework.Core.Services;
using Framework.Persistent;

namespace Framework.DomainDriven.Audit;

public class AuditPropertyPair<TDomainObject> : IEnumerable<IAuditProperty>
{
    private readonly IAuditProperty<TDomainObject, string> authorAudit;

    private readonly IAuditProperty<TDomainObject, DateTime?> dateAudit;


    public AuditPropertyPair(Expression<Func<TDomainObject, string>> authorPropertyExpr, Expression<Func<TDomainObject, DateTime?>> datePropertyExpr, IUserAuthenticationService userAuthenticationService, IDateTimeService dateTimeService)
            : this(new AuditProperty<TDomainObject, string>(authorPropertyExpr, userAuthenticationService.GetUserName), new AuditProperty<TDomainObject, DateTime?>(datePropertyExpr, () => dateTimeService.Now))
    {
        if (userAuthenticationService == null) throw new ArgumentNullException(nameof(userAuthenticationService));
        if (dateTimeService == null) throw new ArgumentNullException(nameof(dateTimeService));
    }

    public AuditPropertyPair(IAuditProperty<TDomainObject, string> authorAudit, IAuditProperty<TDomainObject, DateTime?> dateAudit)
    {
        this.authorAudit = authorAudit ?? throw new ArgumentNullException(nameof(authorAudit));
        this.dateAudit = dateAudit ?? throw new ArgumentNullException(nameof(dateAudit));
    }


    public IEnumerator<IAuditProperty> GetEnumerator()
    {
        yield return this.authorAudit;
        yield return this.dateAudit;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

public class AuditPropertyPair : AuditPropertyPair<IAuditObject>
{
    public AuditPropertyPair(IUserAuthenticationService userAuthenticationService,
                             IDateTimeService dateTimeService,
                             Expression<Func<IAuditObject, string>> authorPropertyExpr,
                             Expression<Func<IAuditObject, DateTime?>> datePropertyExpr)
            : base(authorPropertyExpr, datePropertyExpr, userAuthenticationService, dateTimeService)
    {
    }

    public AuditPropertyPair(IAuditProperty<IAuditObject, string> authorAudit, IAuditProperty<IAuditObject, DateTime?> dateAudit)
            : base(authorAudit, dateAudit)
    {

    }


    public static AuditPropertyPair GetCreateAuditProperty(IUserAuthenticationService userAuthenticationService, IDateTimeService dateTimeService) => new AuditPropertyPair(userAuthenticationService, dateTimeService, obj => obj.CreatedBy, obj => obj.CreateDate);

    public static AuditPropertyPair GetModifyAuditProperty(IUserAuthenticationService userAuthenticationService, IDateTimeService dateTimeService) => new AuditPropertyPair(userAuthenticationService, dateTimeService, obj => obj.ModifiedBy, obj => obj.ModifyDate);
}
