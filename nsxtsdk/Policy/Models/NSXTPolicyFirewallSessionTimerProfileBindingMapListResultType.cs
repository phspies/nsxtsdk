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
    public class NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType : NSXTListResultType
    {
        /// <summary>
        /// Firewall Session Timer Profile Binding Map list results
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        public IList<NSXTPolicyFirewallSessionTimerProfileBindingMapType> Results { get; set; }
    }
}
