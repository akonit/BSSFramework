﻿using System.CodeDom;

using Framework.CodeDom;
using Framework.Core;
using Framework.DomainDriven.BLL;
using Framework.DomainDriven.BLL.Security;
using Framework.SecuritySystem;
using Framework.Transfering;

using SecurityProviderExtensions = Framework.SecuritySystem.SecurityProviderExtensions;

namespace Framework.DomainDriven.ServiceModelGenerator;

public class CheckAccessMethodGenerator<TConfiguration> : MethodGenerator<TConfiguration, BLLViewRoleAttribute>
        where TConfiguration : class, IGeneratorConfigurationBase<IGenerationEnvironmentBase>
{
    public CheckAccessMethodGenerator(TConfiguration configuration, Type domainType)
            : base(configuration, domainType)
    {
    }


    public override MethodIdentity Identity { get; } = MethodIdentityType.CheckAccess;


    protected override string Name => $"Check{this.DomainType.Name}Access";

    protected override CodeTypeReference ReturnType { get; } = typeof(void).ToTypeReference();

    protected override bool IsEdit { get; } = false;

    protected override bool RequiredSecurity { get; } = false;


    protected override string GetComment()
    {
        return $"Check {this.DomainType.Name} access";
    }

    private CodeParameterDeclarationExpression SecurityOperationCodeParameter => typeof(string).ToTypeReference().ToParameterDeclarationExpression("securityOperationName");

    protected override IEnumerable<CodeParameterDeclarationExpression> GetParameters()
    {
        yield return this.Configuration.Environment.ServerDTO
                         .GetCodeTypeReference(this.DomainType, DTOType.IdentityDTO)
                         .ToParameterDeclarationExpression(this.DomainType.Name.ToStartLowerCase() + "Ident");

        yield return this.SecurityOperationCodeParameter;
    }

    protected override IEnumerable<CodeStatement> GetFacadeMethodInternalStatements(CodeExpression evaluateDataExpr, CodeExpression bllRefExpr)
    {
        var operationVarStatement = new CodeVariableDeclarationStatement(typeof(SecurityOperation), "operation", this.GetConvertToSecurityOperationCodeParameterExpression(1));

        yield return operationVarStatement;

        var domainObjectVarDecl = this.ToDomainObjectVarDeclById(bllRefExpr);
        var method = typeof(SecurityProviderExtensions).ToTypeReferenceExpression().ToMethodReferenceExpression(nameof(SecurityProviderExtensions.CheckAccess));

        yield return domainObjectVarDecl;

        yield return this.Configuration.Environment.BLLCore.GetGetSecurityProviderMethodReferenceExpression(evaluateDataExpr.GetContext(), this.DomainType)
                         .ToMethodInvokeExpression(operationVarStatement.ToVariableReferenceExpression())
                         .ToStaticMethodInvokeExpression(method, domainObjectVarDecl.ToVariableReferenceExpression(), evaluateDataExpr.GetContext().ToPropertyReference((IAccessDeniedExceptionServiceContainer c) => c.AccessDeniedExceptionService))
                         .ToExpressionStatement();
    }
}
