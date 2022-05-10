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
    public class NSXTVdsTopologyType : NSXTManagedResourceType
    {
        /// <summary>
        /// Status of the VDS configuration
        /// </summary>
        [JsonProperty(PropertyName = "vds_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTVdsTopologyVdsStatusEnumType? VdsStatus { get; set; }
        /// <summary>
        /// Virtual network interfaces that will be moved from VLAN Logical switch to Distributed Virtual PortGroup
        /// </summary>
        [JsonProperty(PropertyName = "vmknic")]
        public IList<string> Vmknic { get; set; }
        /// <summary>
        /// Identifier of cluster where VDS will be created
        /// </summary>
        [JsonProperty(PropertyName = "cluster_id")]
        public string? ClusterId { get; set; }
        /// <summary>
        /// Transport node identifiers on which NVDS(s) being upgraded to VDS
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id", Required = Required.AllowNull)]
        public IList<string> TransportNodeId { get; set; }
        /// <summary>
        /// Details of the VDS configuration status
        /// </summary>
        [JsonProperty(PropertyName = "status_details")]
        public IList<string> StatusDetails { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "vds_config")]
        public NSXTDVSConfigType VdsConfig { get; set; }
        /// <summary>
        /// VDS name that will be created under above datacenter
        /// </summary>
        [JsonProperty(PropertyName = "vds_name", Required = Required.AllowNull)]
        public string VdsName { get; set; }
        /// <summary>
        /// Identifier of datacenter where VDS will be created
        /// </summary>
        [JsonProperty(PropertyName = "data_center_id", Required = Required.AllowNull)]
        public string DataCenterId { get; set; }
    }
}
