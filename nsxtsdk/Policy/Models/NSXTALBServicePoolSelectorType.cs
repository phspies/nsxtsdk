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
    /// Advanced load balancer ServicePoolSelector object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer ServicePoolSelector object")]
    public class NSXTALBServicePoolSelectorType 
    {
        /// <summary>
        /// Destination protocol to match for the pool selection.
        /// If not specified, it will match any protocol.
        /// Enum options - PROTOCOL_TYPE_TCP_PROXY,
        /// PROTOCOL_TYPE_TCP_FAST_PATH, PROTOCOL_TYPE_UDP_FAST_PATH,
        /// PROTOCOL_TYPE_UDP_PROXY.
        /// </summary>
        [JsonProperty(PropertyName = "service_protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbservicePoolSelectorServiceProtocolEnumType? ServiceProtocol { get; set; }
        /// <summary>
        /// It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "service_pool_path")]
        public string? ServicePoolPath { get; set; }
        /// <summary>
        /// The end of the Service port number range.
        /// Allowed values are 1-65535.
        /// Special values are 0- 'single port'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "service_port_range_end")]
        public long? ServicePortRangeEnd { get; set; }
        /// <summary>
        /// It is a reference to an object of type PoolGroup.
        /// </summary>
        [JsonProperty(PropertyName = "service_pool_group_path")]
        public string? ServicePoolGroupPath { get; set; }
        /// <summary>
        /// Pool based destination port.
        /// Allowed values are 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "service_port", Required = Required.AllowNull)]
        public long ServicePort { get; set; }
    }
}
