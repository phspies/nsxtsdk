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
    public class NSXTPolicyBasedL3VpnSessionType : NSXTL3VpnSessionType
    {
        /// <summary>
        /// L3Vpn rules that are specific to the L3Vpn. Only L3Vpn rules with PROTECT action
        /// are supported.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTL3VpnRuleType> Rules { get; set; }
    }
}
