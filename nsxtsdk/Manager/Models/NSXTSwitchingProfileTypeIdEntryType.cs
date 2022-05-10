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
    public class NSXTSwitchingProfileTypeIdEntryType 
    {
        /// <summary>
        /// key value
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public string Value { get; set; }
        /// <summary>
        /// Supported switching profiles.
        /// 'PortMirroringSwitchingProfile' is deprecated, please turn to
        /// "Troubleshooting And Monitoring: Portmirroring" and use
        /// PortMirroringSession API for port mirror function.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSwitchingProfileTypeIdEntryKeyEnumType? Key { get; set; }
    }
}
