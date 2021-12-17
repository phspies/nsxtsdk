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
    /// Details where NVDS will be migrated to
    /// </summary>
    [NSXTProperty(Description: @"Details where NVDS will be migrated to")]
    public class NSXTComputeManagerTopologyType 
    {
        public NSXTComputeManagerTopologyType()
        {
        }
        /// <summary>
        /// Datacenter, VDS mapping
        /// </summary>
        [JsonProperty(PropertyName = "dvswitch", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Datacenter, VDS mapping")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTVdsTopologyType> Dvswitch { get; set; }
        /// <summary>
        /// Identifier of vcenter where VDS will be created
        /// </summary>
        [JsonProperty(PropertyName = "compute_manager_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Identifier of vcenter where VDS will be created")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ComputeManagerId { get; set; }
    }
}
