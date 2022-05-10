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
    public class NSXTNSXTConnectionInfoType : NSXTEnforcementPointConnectionInfoType
    {
        /// <summary>
        /// Username.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// Transport Zone UUIDs on enforcement point. Transport zone information is
        /// required for creating logical L2, L3 constructs on enforcement point.
        /// Max 1 transport zone ID.
        /// This is a deprecated property. The transport zone id is now auto
        /// populated from enforcement point and its value can be read using APIs
        /// GET /infra/sites/site-id/enforcement-points/enforcementpoint-id/transport-zones and
        /// GET /infra/sites/site-id/enforcement-points/enforcementpoint-id/transport-zones/transport-zone-id.
        /// The value passed through this property will be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_ids")]
        public IList<string> TransportZoneIds { get; set; }
        /// <summary>
        /// Password.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Edge Cluster UUIDs on enforcement point. Edge cluster information is
        /// required for creating logical L2, L3 constructs on enforcement point.
        /// Max 1 edge cluster ID.
        /// This is a deprecated property. The edge cluster id is now auto
        /// populated from enforcement point and its value can be read using APIs
        /// GET /infra/sites/site-id/enforcement-points/enforcementpoint-id/edge-clusters and
        /// GET /infra/sites/site-id/enforcement-points/enforcementpoint-1/edge-clusters/edge-cluster-id.
        /// The value passed through this property will be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_ids")]
        public IList<string> EdgeClusterIds { get; set; }
        /// <summary>
        /// Thumbprint of EnforcementPoint in the form of a SHA-256 hash represented in lower case HEX.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string? Thumbprint { get; set; }
    }
}
