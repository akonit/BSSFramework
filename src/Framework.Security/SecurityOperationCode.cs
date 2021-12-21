﻿namespace Framework.Security
{
     /// <summary>
     /// Описание секьюрной операции.
     /// </summary>
    public enum SecurityOperationCode
    {
        Disabled = 0,

        #region Authorization

        #region Principal

        [SecurityOperation("Open Principal Module", false, "{5E72E6A4-33BB-4F0F-8928-0C2D44429CC6}", "Can open Principal module", DomainType = "Principal", IsClient = true)]
        PrincipalOpenModule,

        [SecurityOperation("View Principal", false, "{5031A272-B730-4E65-9D56-50B3E0441C4F}", "Can view Principal", DomainType = "Principal")]
        PrincipalView,

        [SecurityOperation("Edit Principal", false, "{3DC58D7B-85A0-43E1-8E54-E23F9A360E7B}", "Can edit Principal", DomainType = "Principal")]
        PrincipalEdit,

        #endregion

        #region BusinessRole

        [SecurityOperation("Open BusinessRole Module", false, "76477C2A-C0EF-4CC3-BE15-1087AAC9AE6E", "Can open BusinessRole module", DomainType = "BusinessRole", IsClient = true)]
        BusinessRoleOpenModule,

        [SecurityOperation("View BusinessRole", false, "{641CB98E-F47D-4F4A-9183-D969BA1434D4}", "Can view BusinessRole", DomainType = "BusinessRole")]
        BusinessRoleView,

        [SecurityOperation("Edit BusinessRole", false, "{44F519AE-ACD8-487B-94BA-BBD897DF687A}", "Can edit BusinessRole", DomainType = "BusinessRole")]
        BusinessRoleEdit,

        #endregion

        #region Operation

        [SecurityOperation("Open Operation Module", false, "{E50E7F5A-F042-4239-BA57-1D34C084F42F}", "Can open Operation module", DomainType = "Operation", IsClient = true)]
        OperationOpenModule,

        [SecurityOperation("View Operation", false, "{9B0F5A86-5ECC-44DB-B325-8F2FCD7C2E46}", "Can view Operation", DomainType = "Operation")]
        OperationView,

        [SecurityOperation("Edit Operation", false, "{7D148DAD-D4F7-45E3-B087-2125ABCD8A58}", "Can edit Operation", DomainType = "Operation")]
        OperationEdit,

        #endregion

        [SecurityOperation("Authorization Impersonate", false, "{E48D7030-FC38-4416-8C7F-F08764D884E3}", "Can authorization impersonate")]
        AuthorizationImpersonate,

        #endregion

        #region Configuration

        #region ExceptionMessage

        [SecurityOperation("Open ExceptionMessage Module", false, "{D2804808-18B5-400A-AB4A-44F350A754AE}", "ExceptionMessage", DomainType = "ExceptionMessage", IsClient = true)]
        ExceptionMessageOpenModule,

        [SecurityOperation("View ExceptionMessage", false, "{095CC891-4D06-436E-A884-774B4D592C8C}", "Can view ExceptionMessage", DomainType = "ExceptionMessage")]
        ExceptionMessageView,

        #endregion

        #region MessageTemplate

        [SecurityOperation("Open MessageTemplate Module", false, "A7F32FF3-F514-4C65-AEB2-DF07A4773DBB", "MessageTemplate", DomainType = "MessageTemplate", IsClient = true)]
        MessageTemplateOpenModule,

        [SecurityOperation("View MessageTemplate", false, "32389C1C-0BEF-47AE-9C77-E06CA16E3649", "Can view MessageTemplate", DomainType = "MessageTemplate")]
        MessageTemplateView,

        [SecurityOperation("Edit MessageTemplate", false, "8FCC9513-EABF-404B-A435-CCCFEFDCB3F4", "Can edit MessageTemplate", DomainType = "MessageTemplate")]
        MessageTemplateEdit,

        #endregion

        #region ExceptionTemplate

        [SecurityOperation("Open ExceptionTemplate Module", false, "{AC71795B-871A-484A-90BC-58641BB28F9F}", "Can open ExceptionTemplate module", DomainType = "ExceptionTemplate", IsClient = true)]
        ExceptionTemplateOpenModule,

        [SecurityOperation("View ExceptionTemplate", false, "{A98C3C63-520C-4694-84F4-56C66D0F61DE}", "Can view ExceptionTemplate", DomainType = "ExceptionTemplate")]
        ExceptionTemplateView,

        [SecurityOperation("Edit ExceptionTemplate", false, "{74FA95AB-AA44-46C2-BE81-F9435A40FAA1}", "Can edit ExceptionTemplate", DomainType = "ExceptionTemplate")]
        ExceptionTemplateEdit,

        #endregion

        #region Subscription

        [SecurityOperation("Open Subscription Module", false, "{4065A2DF-AE7E-4DDB-AB94-7825DAA9D30A}", DomainType = "Subscription", IsClient = true)]
        SubscriptionOpenModule,

        [SecurityOperation("SubscriptionView", false, "D17C8617-0213-44BD-9776-33254C5A75D8", "Subscriptions", DomainType = "Subscription")]
        SubscriptionView,

        [SecurityOperation("SubscriptionEdit", false, "3C209F89-023F-44E5-B30C-CF0A20647CD6", "Subscriptions", DomainType = "Subscription")]
        SubscriptionEdit,

        [SecurityOperation("SubscriptionTest", false, "{9A3FE9E8-642F-4FFD-BABF-A82771AFB397}", "Subscriptions", DomainType = "Subscription")]
        SubscriptionTest,

        #endregion

        #region RegularJob

        [SecurityOperation("Open RegularJob Module", false, "B4169486-700B-4273-B558-542BE0EF987E", DomainType = "RegularJob", IsClient = true)]
        RegularJobModuleOpenModule,

        [SecurityOperation("RegularJobView", false, "AB46D7C9-22E3-4055-AEB3-9D7E6ADE6028", "RegularJob", DomainType = "RegularJob")]
        RegularJobView,

        [SecurityOperation("RegularJobEdit", false, "85AA19B0-3428-40FA-B01F-0441D74A7F17", "RegularJob", DomainType = "RegularJob")]
        RegularJobEdit,

        /// <summary>
        /// Форсирование запуска RegularJob-а
        /// </summary>
        [SecurityOperation("RegularJob", false, "{874BB5AF-262B-4399-A971-FDD423292383}", "Force Run RegularJob", DomainType = "RegularJob")]
        RegularJobForce,

        #endregion

        #region Reports

        [SecurityOperation("Open Report Module", false, "634530F7-9D3B-4920-8A22-D1FDDC92F8AE", DomainType = "Report", IsClient = true)]
        ReportOpenModule,

        [SecurityOperation("ReportView", false, "62BA8B83-152D-47A6-A412-52BAC8E451FA", "Report", DomainType = "Report")]
        ReportView,

        [SecurityOperation("ReportEdit", false, "933920E2-ED24-4F8F-90B9-4B3CB2A9F74B", "Report", DomainType = "Report")]
        ReportEdit,

        [SecurityOperation("ReportGeneration", false, "76C6BC45-C2B6-4271-AEAA-445457579EB0", "Report", DomainType = "Report")]
        ReportGeneration,

        #endregion

        #region SystemConstant

        [SecurityOperation("Open SystemConstant Module", false, "0CDCA9B4-B35B-4D40-AE6B-1BE59164416E", DomainType = "SystemConstant", IsClient = true)]
        SystemConstantOpenModule,

        [SecurityOperation("SystemConstantView", false, "3B348AE9-CAFC-45B2-AE8C-E26F9DC92B2E", "SystemConstant", DomainType = "SystemConstant")]
        SystemConstantView,

        [SecurityOperation("SystemConstantEdit", false, "D8B07D34-261A-4A61-9B14-A349BFA87837", "SystemConstant", DomainType = "SystemConstant")]
        SystemConstantEdit,

        #endregion

        #region Sequence

        [SecurityOperation("Open Sequence Module", false, "A217F6F2-F9D9-49C7-B94F-0FD0981F0A5F", "Can open Sequence module", DomainType = "Sequence", IsClient = true)]
        SequenceOpenModule,

        [SecurityOperation("View Sequence", false, "3F16CE67-E445-4627-8D52-75079B191191", "Can view Sequence", DomainType = "Sequence")]
        SequenceView,

        [SecurityOperation("Edit Sequence", false, "3E70A766-C40A-485E-BC1B-38E6600F9F8A", "Can edit Sequence", DomainType = "Sequence")]
        SequenceEdit,

        #endregion

        /// <summary>
        /// Отображение внутренних серверных ошибок клиенту
        /// </summary>
        [SecurityOperation("Integration", false, "{AB8AFD01-40D2-48D0-B5F3-A12177B00D0D}", "Display Internal Error", adminHasAccess: false)]
        DisplayInternalError,

        /// <summary>
        /// Операция для форсирования создания нотификаций из модификаций хранящихся в локальной бд
        /// </summary>
        [SecurityOperation("Integration", false, "{C1EF265C-D118-4FCE-A251-27A542787449}", "Process Modifications", adminHasAccess: false)]
        ProcessModifications,

        /// <summary>
        /// Операция для мониторинга состояния обработки очередей в утилитах (евентов, модификаций, нотификаций)
        /// </summary>
        [SecurityOperation("Integration", false, "{3F17FC3B-F923-43BB-AAB7-87E5C8A2E0B3}", "Queue Monitoring")]
        QueueMonitoring,

        #endregion

        #region Workflow

        [SecurityOperation("Open Workflow Module", false, "{F0CCE81F-D710-4456-A7ED-C8B181BA3443}", "Can open Workflow module", DomainType = "Workflow", IsClient = true)]
        WorkflowOpenModule,

        [SecurityOperation("View Workflow", false, "{10CE7EDF-45C3-4285-81FB-4399A5907890}", "Can view Workflow", DomainType = "Workflow")]
        WorkflowView,

        [SecurityOperation("Edit Workflow", false, "{3C84B2B4-40CE-4F37-9CD7-D4CC38E8C9C0}", "Can edit Workflow", DomainType = "Workflow")]
        WorkflowEdit,

        #endregion

        #region Integration

        /// <summary>
        /// Операции производимые системами для интеграции (Biztalk и т.д.)
        /// </summary>
        [SecurityOperation("Integration", false, "{0BA8A6B0-43B9-4F59-90CE-2FCBE37B97C9}", "Can integrate", adminHasAccess: false)]
        SystemIntegration,

        #endregion

        #region TargetSystem

        [SecurityOperation("TargetSystemOpenModule", false, "{CF3BBD62-04B7-4D8A-B53E-75F0B93F12CB}", DomainType = "TargetSystem", IsClient = true)]
        TargetSystemOpenModule,

        [SecurityOperation("TargetSystemView", false, "{B5AC42D9-456F-40B8-BA8E-A7084E972AF7}", DomainType = "TargetSystem")]
        TargetSystemView,

        [SecurityOperation("TargetSystemEdit", false, "{5B122470-F5EF-4FFA-AC93-0EEA9B8E4464}", DomainType = "TargetSystem")]
        TargetSystemEdit,

        /// <summary>
        /// Операция для ручного инициирования событый
        /// </summary>
        [SecurityOperation("TargetSystem", false, "{3106D276-575A-470F-A346-31C2FF47D517}", DomainType = "DomainType")]
        ForceDomainTypeEvent,

        #endregion

        #region UserAction

        [SecurityOperation("Open UserAction Module", false, "{07FB374C-F7DA-4D0A-8A64-97EB5F9DF803}", DomainType = "UserAction", IsClient = true)]
        UserActionOpenModule,

        [SecurityOperation("UserAction View", false, "{E5EF38FC-F2FF-4F12-A81B-1D4A14B5442A}", "UserAction", DomainType = "UserAction")]
        UserActionView,

        #endregion
    }
}
