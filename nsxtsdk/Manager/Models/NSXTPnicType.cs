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
    /// Physical NIC specification
    /// </summary>
    [NSXTProperty(Description: @"Physical NIC specification")]
    public class NSXTPnicType 
    {
        /// <summary>
        /// Uplink name for this Pnic. This name will be used to reference this Pnic in other configurations.
        /// </summary>
        [JsonProperty(PropertyName = "uplink_name", Required = Required.AllowNull)]
        public string UplinkName { get; set; }
        /// <summary>
        /// device name or key
        /// </summary>
        [JsonProperty(PropertyName = "device_name", Required = Required.AllowNull)]
        public string DeviceName { get; set; }
    }
}
