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
    public class NSXTPolicyEdgeClusterType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Flag to indicate status of inter site l2 and l3 forwarding in federation.
        /// </summary>
        [JsonProperty(PropertyName = "inter_site_forwarding_enabled")]
        public bool? InterSiteForwardingEnabled { get; set; }
        /// <summary>
        /// UUID of Edge Cluster on NSX-T enforcement point.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_id")]
        public string? NsxId { get; set; }
        /// <summary>
        /// List of remote tunnel endpoint ipaddress configured on edge cluster.
        /// </summary>
        [JsonProperty(PropertyName = "rtep_ips")]
        public IList<string> RtepIps { get; set; }
    }
}
