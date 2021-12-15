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
        [NSXTProperty(IsRequired: true, Description: @"Policy rules")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTIPSecVPNPolicyRuleType> PolicyRules { get; set; }
    }
}
