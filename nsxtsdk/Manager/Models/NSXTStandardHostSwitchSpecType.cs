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
    public class NSXTStandardHostSwitchSpecType : NSXTHostSwitchSpecType
    {
        /// <summary>
        /// Transport Node host switches
        /// </summary>
        [JsonProperty(PropertyName = "host_switches", Required = Required.AllowNull)]
        public IList<NSXTStandardHostSwitchType> HostSwitches { get; set; }
    }
}
