﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\DomainChangedByRecipients\NotPersistentCustomModel\MessageTemplate.cshtml"
    using Framework.Configuration.SubscriptionModeling;
    
    #line default
    #line hidden
    
    #line 3 "..\..\DomainChangedByRecipients\NotPersistentCustomModel\MessageTemplate.cshtml"
    using SampleSystem.Subscriptions.Metadata.DomainChangedByRecipients.NotPersistentCustomModel;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class _DomainChangedByRecipients_NotPersistentCustomModel_MessageTemplate_cshtml : RazorTemplate<CustomNotificationModel>
    {
#line hidden

        #line 5 "..\..\DomainChangedByRecipients\NotPersistentCustomModel\MessageTemplate.cshtml"

    public override string Subject => $"Country {Current.Country.Code} has been updated";

        #line default
        #line hidden

        public override void Execute()
        {



            
            #line 1 "..\..\DomainChangedByRecipients\NotPersistentCustomModel\MessageTemplate.cshtml"
                          

            
            #line default
            #line hidden




WriteLiteral("\r\n<html>\r\n    <head></head>\r\n    <body>\r\n    <p>Country with code: ");


            
            #line 11 "..\..\DomainChangedByRecipients\NotPersistentCustomModel\MessageTemplate.cshtml"
                     Write(Current.Country.Code);

            
            #line default
            #line hidden
WriteLiteral(" was updated and has ");


            
            #line 11 "..\..\DomainChangedByRecipients\NotPersistentCustomModel\MessageTemplate.cshtml"
                                                               Write(Current.LocationsCount);

            
            #line default
            #line hidden
WriteLiteral(" locations</p>\r\n    <img src=\"");


            
            #line 12 "..\..\DomainChangedByRecipients\NotPersistentCustomModel\MessageTemplate.cshtml"
         Write(AttachmentLambda.AttachmentName);

            
            #line default
            #line hidden
WriteLiteral("\"/>\r\n    </body>\r\n</html>\r\n");


        }
    }
}
#pragma warning restore 1591
