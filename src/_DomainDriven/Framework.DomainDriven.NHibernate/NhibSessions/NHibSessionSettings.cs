﻿using Framework.Core.Services;
using Framework.DomainDriven.Audit;



namespace Framework.DomainDriven.NHibernate;

public class NHibSessionSettings : INHibSessionSetup
{
    
    private readonly IUserAuthenticationService userAuthenticationService;

    
    private readonly IDateTimeService dateTimeService;

    public NHibSessionSettings(
            IUserAuthenticationService userAuthenticationService,
            IDateTimeService dateTimeService)
    {
        this.userAuthenticationService = userAuthenticationService ?? throw new ArgumentNullException(nameof(userAuthenticationService));
        this.dateTimeService = dateTimeService ?? throw new ArgumentNullException(nameof(dateTimeService));
    }

    public DBSessionMode DefaultSessionMode { get; } = DBSessionMode.Write;

    public AuditPropertyPair GetCreateAuditProperty() => AuditPropertyPair.GetCreateAuditProperty(this.userAuthenticationService, this.dateTimeService);

    public AuditPropertyPair GetModifyAuditProperty() => AuditPropertyPair.GetModifyAuditProperty(this.userAuthenticationService, this.dateTimeService);
}
