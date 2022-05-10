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
    public class NSXTNodeRoutePropertiesType : NSXTResourceType
    {
        /// <summary>
        /// Source address to prefer when sending to destinations of route
        /// </summary>
        [JsonProperty(PropertyName = "src")]
        public string? Src { get; set; }
        /// <summary>
        /// From address
        /// </summary>
        [JsonProperty(PropertyName = "from_address")]
        public string? FromAddress { get; set; }
        /// <summary>
        /// Routing protocol identifier of route
        /// </summary>
        [JsonProperty(PropertyName = "proto")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeRoutePropertiesProtoEnumType? Proto { get; set; }
        /// <summary>
        /// Route type
        /// </summary>
        [JsonProperty(PropertyName = "route_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeRoutePropertiesRouteTypeEnumType RouteType { get; set; }
        /// <summary>
        /// Metric value of route
        /// </summary>
        [JsonProperty(PropertyName = "metric")]
        public string? Metric { get; set; }
        /// <summary>
        /// Destination covered by route
        /// </summary>
        [JsonProperty(PropertyName = "destination")]
        public string? Destination { get; set; }
        /// <summary>
        /// Network interface id of route
        /// </summary>
        [JsonProperty(PropertyName = "interface_id")]
        public string? InterfaceId { get; set; }
        /// <summary>
        /// Unique identifier for the route
        /// </summary>
        [JsonProperty(PropertyName = "route_id")]
        public string? RouteId { get; set; }
        /// <summary>
        /// Netmask of destination covered by route
        /// </summary>
        [JsonProperty(PropertyName = "netmask")]
        public string? Netmask { get; set; }
        /// <summary>
        /// Scope of destinations covered by route
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string? Scope { get; set; }
        /// <summary>
        /// Address of next hop
        /// </summary>
        [JsonProperty(PropertyName = "gateway")]
        public string? Gateway { get; set; }
    }
}
