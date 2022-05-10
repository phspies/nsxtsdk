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
    /// Object to identify an uplink based on its type and name
    /// </summary>
    [NSXTProperty(Description: @"Object to identify an uplink based on its type and name")]
    public class NSXTUplinkType 
    {
        /// <summary>
        /// Name of this uplink
        /// </summary>
        [JsonProperty(PropertyName = "uplink_name", Required = Required.AllowNull)]
        public string UplinkName { get; set; }
        /// <summary>
        /// Type of the uplink
        /// </summary>
        [JsonProperty(PropertyName = "uplink_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUplinkUplinkTypeEnumType UplinkType { get; set; }
    }
}
