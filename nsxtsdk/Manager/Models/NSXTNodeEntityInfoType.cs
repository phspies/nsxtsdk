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
    public class NSXTNodeEntityInfoType 
    {
        /// <summary>
        /// IP address of service provider
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string? IpAddress { get; set; }
        /// <summary>
        /// Port number of service provider
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
        /// <summary>
        /// Entity type of this service endpoint
        /// </summary>
        [JsonProperty(PropertyName = "entity_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeEntityInfoEntityTypeEnumType? EntityType { get; set; }
    }
}
