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
    /// Details where NVDS will be migrated to
    /// </summary>
    [NSXTProperty(Description: @"Details where NVDS will be migrated to")]
    public class NSXTComputeManagerTopologyType 
    {
        /// <summary>
        /// Datacenter, VDS mapping
        /// </summary>
        [JsonProperty(PropertyName = "dvswitch", Required = Required.AllowNull)]
        public IList<NSXTVdsTopologyType> Dvswitch { get; set; }
        /// <summary>
        /// Identifier of vcenter where VDS will be created
        /// </summary>
        [JsonProperty(PropertyName = "compute_manager_id", Required = Required.AllowNull)]
        public string ComputeManagerId { get; set; }
    }
}
