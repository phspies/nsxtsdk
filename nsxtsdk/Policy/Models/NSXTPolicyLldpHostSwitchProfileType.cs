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
    public class NSXTPolicyLldpHostSwitchProfileType : NSXTPolicyBaseHostSwitchProfileType
    {
        /// <summary>
        /// Enabled or disabled sending LLDP packets
        /// </summary>
        [JsonProperty(PropertyName = "send_enabled", Required = Required.AllowNull)]
        public bool SendEnabled { get; set; }
    }
}
