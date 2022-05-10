using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

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
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRuleActionEnumType? Action { get; set; }
    }
}
