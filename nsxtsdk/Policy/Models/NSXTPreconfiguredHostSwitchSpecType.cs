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
    public class NSXTPreconfiguredHostSwitchSpecType : NSXTHostSwitchSpecType
    {
        /// <summary>
        /// Preconfigured Transport Node host switches
        /// </summary>
        [JsonProperty(PropertyName = "host_switches", Required = Required.AllowNull)]
        public IList<NSXTPreconfiguredHostSwitchType> HostSwitches { get; set; }
    }
}
