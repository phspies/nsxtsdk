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
    public class NSXTFirewallSectionRuleListType : NSXTFirewallSectionType
    {
        /// <summary>
        /// List of firewall rules in the section. Only homogenous rules are supported.
        /// </summary>
        [JsonProperty(PropertyName = "rules", Required = Required.AllowNull)]
        public IList<NSXTFirewallRuleType> Rules { get; set; }
    }
}
