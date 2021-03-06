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
    public class NSXTLldpHostSwitchProfileType : NSXTBaseHostSwitchProfileType
    {
        /// <summary>
        /// Enabled or disabled sending LLDP packets
        /// </summary>
        [JsonProperty(PropertyName = "send_enabled", Required = Required.AllowNull)]
        public bool SendEnabled { get; set; }
    }
}
