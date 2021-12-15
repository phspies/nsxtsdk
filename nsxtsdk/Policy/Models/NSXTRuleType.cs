// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTRuleType : NSXTBaseRuleType
    {
        /// <summary>
        /// The action to be applied to all the services
        /// The JUMP_TO_APPLICATION action is only supported for rules created in the
        /// Environment category. Once a match is hit then the rule processing
        /// will jump to the rules present in the Application category, skipping
        /// all further rules in the Environment category. If no rules match in
        /// the Application category then the default application rule will be hit.
        /// This is applicable only for DFW.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [NSXTProperty(IsRequired: false, Description: @"The action to be applied to all the servicesThe JUMP_TO_APPLICATION action is only supported for rules created in theEnvironment category. Once a match is hit then the rule processingwill jump to the rules present in the Application category, skippingall further rules in the Environment category. If no rules match inthe Application category then the default application rule will be hit.This is applicable only for DFW.")]
        public NSXTRuleActionEnumType? Action { get; set; }
    }
}
