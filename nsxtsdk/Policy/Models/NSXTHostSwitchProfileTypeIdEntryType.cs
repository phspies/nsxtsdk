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
    public class NSXTHostSwitchProfileTypeIdEntryType 
    {
        /// <summary>
        /// key value
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public string Value { get; set; }
        /// <summary>
        /// Supported HostSwitch profiles.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTHostSwitchProfileTypeIdEntryKeyEnumType? Key { get; set; }
    }
}
