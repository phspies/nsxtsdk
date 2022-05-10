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
    public class NSXTDiscoveredNodeType : NSXTDiscoveredResourceType
    {
        /// <summary>
        /// The stateless property describes whether host persists its state across reboot or not. If state persists, value is set
        /// as false otherwise true.
        /// </summary>
        [JsonProperty(PropertyName = "stateless")]
        public bool? Stateless { get; set; }
        /// <summary>
        /// External id of the compute collection to which this node belongs
        /// </summary>
        [JsonProperty(PropertyName = "parent_compute_collection")]
        public string? ParentComputeCollection { get; set; }
        /// <summary>
        /// Certificate of the discovered node
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public string? Certificate { get; set; }
        /// <summary>
        /// Id of the compute manager from where this node was discovered
        /// </summary>
        [JsonProperty(PropertyName = "origin_id")]
        public string? OriginId { get; set; }
        /// <summary>
        /// IP Addresses of the the discovered node.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses")]
        public IList<string> IpAddresses { get; set; }
        /// <summary>
        /// Hardware Id is generated using system hardware info. It is used to retrieve fabric node of the esx.
        /// </summary>
        [JsonProperty(PropertyName = "hardware_id")]
        public string? HardwareId { get; set; }
        /// <summary>
        /// OS version of the discovered node
        /// </summary>
        [JsonProperty(PropertyName = "os_version")]
        public string? OsVersion { get; set; }
        /// <summary>
        /// Discovered Node type like Host
        /// </summary>
        [JsonProperty(PropertyName = "node_type")]
        public string? NodeType { get; set; }
        /// <summary>
        /// OS type of the discovered node
        /// </summary>
        [JsonProperty(PropertyName = "os_type")]
        public string? OsType { get; set; }
        /// <summary>
        /// Key-Value map of additional specific properties of discovered
        /// node in the Compute Manager
        /// </summary>
        [JsonProperty(PropertyName = "origin_properties")]
        public IList<NSXTKeyValuePairType> OriginProperties { get; set; }
        /// <summary>
        /// External id of the discovered node, ex. a mo-ref from VC
        /// </summary>
        [JsonProperty(PropertyName = "external_id")]
        public string? ExternalId { get; set; }
        /// <summary>
        /// Local Id of the discovered node in the Compute Manager
        /// </summary>
        [JsonProperty(PropertyName = "cm_local_id")]
        public string? CmLocalId { get; set; }
    }
}
