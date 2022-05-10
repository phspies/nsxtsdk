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
    public class NSXTDhcpProfileType : NSXTManagedResourceType
    {
        /// <summary>
        /// The Edge nodes on which the DHCP servers run. If none is provided, the
        /// NSX will auto-select two edge-nodes from the given edge cluster. If only
        /// one edge node is provided, the DHCP servers will run without HA support.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_member_indexes")]
        public long? EdgeClusterMemberIndexes { get; set; }
        /// <summary>
        /// Flag to enable the auto-relocation of standby DHCP Service in case
        /// of edge node failure. Only tier 1 and auto placed DHCP servers are
        /// considered for the relocation.
        /// </summary>
        [JsonProperty(PropertyName = "enable_standby_relocation")]
        public bool? EnableStandbyRelocation { get; set; }
        /// <summary>
        /// Edge cluster uuid on which the referencing logical DHCP server runs.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_id", Required = Required.AllowNull)]
        public string EdgeClusterId { get; set; }
    }
}
