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
    public class NSXTNvdsUpgradeTopologyType : NSXTManagedResourceType
    {
        /// <summary>
        /// Identifier for a NVDS
        /// </summary>
        [JsonProperty(PropertyName = "nvds_id", Required = Required.AllowNull)]
        public string NvdsId { get; set; }
        /// <summary>
        /// Name of a NVDS
        /// </summary>
        [JsonProperty(PropertyName = "nvds_name", Required = Required.AllowNull)]
        public string NvdsName { get; set; }
        /// <summary>
        /// All resultant VDS mapping for a NVDS after the migration
        /// </summary>
        [JsonProperty(PropertyName = "compute_manager_topology", Required = Required.AllowNull)]
        public IList<NSXTComputeManagerTopologyType> ComputeManagerTopology { get; set; }
    }
}
