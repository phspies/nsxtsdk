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
    /// Advanced load balancer IPPersistenceProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer IPPersistenceProfile object")]
    public class NSXTALBIPPersistenceProfileType 
    {
        /// <summary>
        /// Mask to be applied on client IP.
        /// This may be used to persist clients from a subnet to the
        /// same server.
        /// When set to 0, all requests are sent to the same server.
        /// Allowed values are 0-128.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "ip_mask")]
        public long? IpMask { get; set; }
        /// <summary>
        /// The length of time after a client's connections have closed
        /// before expiring the client's persistence to a server.
        /// Allowed values are 1-720.
        /// Unit is MIN.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 5.
        /// </summary>
        [JsonProperty(PropertyName = "ip_persistent_timeout")]
        public long? IpPersistentTimeout { get; set; }
    }
}
