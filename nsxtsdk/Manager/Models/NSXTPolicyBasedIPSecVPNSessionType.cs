using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPolicyBasedIPSecVPNSessionType : NSXTIPSecVPNSessionType
    {
        /// <summary>
        /// Policy rules
        /// </summary>
        [JsonProperty(PropertyName = "policy_rules", Required = Required.AllowNull)]
        public IList<NSXTIPSecVPNPolicyRuleType> PolicyRules { get; set; }
    }
}
