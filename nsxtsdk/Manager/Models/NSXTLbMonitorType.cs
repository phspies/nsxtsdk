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
    public class NSXTLbMonitorType : NSXTManagedResourceType
    {
        /// <summary>
        /// Load balancers monitor the health of backend servers to ensure traffic
        /// is not black holed.
        /// There are two types of healthchecks: active and passive.
        /// Passive healthchecks depend on failures in actual client traffic (e.g. RST
        /// from server in response to a client connection) to detect that the server
        /// or the application is down.
        /// In case of active healthchecks, load balancer itself initiates new
        /// connections (or sends ICMP ping) to the servers periodically to check their
        /// health, completely independent of any data traffic.
        /// Currently, active health monitors are supported for HTTP, HTTPS, TCP, UDP
        /// and ICMP protocols.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbMonitorResourceTypeEnumType ResourceType { get; set; }
    }
}
