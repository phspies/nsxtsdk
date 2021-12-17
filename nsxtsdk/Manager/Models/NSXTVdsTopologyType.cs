// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTVdsTopologyType : NSXTManagedResourceType
    {
        public NSXTVdsTopologyType()
        {
        }
        /// <summary>
        /// Status of the VDS configuration
        /// </summary>
        [JsonProperty(PropertyName = "vds_status")]
        [NSXTProperty(IsRequired: false, Description: @"Status of the VDS configuration")]
        public NSXTVdsTopologyVdsStatusEnumType? VdsStatus { get; set; }
        /// <summary>
        /// Virtual network interfaces that will be moved from VLAN Logical switch to Distributed Virtual PortGroup
        /// </summary>
        [JsonProperty(PropertyName = "vmknic")]
        [NSXTProperty(IsRequired: false, Description: @"Virtual network interfaces that will be moved from VLAN Logical switch to Distributed Virtual PortGroup")]
        public IList<string> Vmknic { get; set; }
        /// <summary>
        /// Identifier of cluster where VDS will be created
        /// </summary>
        [JsonProperty(PropertyName = "cluster_id")]
        [NSXTProperty(IsRequired: false, Description: @"Identifier of cluster where VDS will be created")]
        public string? ClusterId { get; set; }
        /// <summary>
        /// Transport node identifiers on which NVDS(s) being upgraded to VDS
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Transport node identifiers on which NVDS(s) being upgraded to VDS")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> TransportNodeId { get; set; }
        /// <summary>
        /// Details of the VDS configuration status
        /// </summary>
        [JsonProperty(PropertyName = "status_details")]
        [NSXTProperty(IsRequired: false, Description: @"Details of the VDS configuration status")]
        public IList<string> StatusDetails { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "vds_config")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTDVSConfigType VdsConfig { get; set; }
        /// <summary>
        /// VDS name that will be created under above datacenter
        /// </summary>
        [JsonProperty(PropertyName = "vds_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"VDS name that will be created under above datacenter")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VdsName { get; set; }
        /// <summary>
        /// Identifier of datacenter where VDS will be created
        /// </summary>
        [JsonProperty(PropertyName = "data_center_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Identifier of datacenter where VDS will be created")]
        [System.ComponentModel.DataAnnotations.Required]
        public string DataCenterId { get; set; }
    }
}
