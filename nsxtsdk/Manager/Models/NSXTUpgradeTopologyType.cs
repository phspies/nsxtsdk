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
    /// Recommended topology for migrating NVDS to VDS
    /// </summary>
    [NSXTProperty(Description: @"Recommended topology for migrating NVDS to VDS")]
    public class NSXTUpgradeTopologyType 
    {
        /// <summary>
        /// All resultant VDS mapping for a NVDS after the migration
        /// </summary>
        [JsonProperty(PropertyName = "topology", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"All resultant VDS mapping for a NVDS after the migration")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTNvdsUpgradeTopologyType> Topology { get; set; }
    }
}
