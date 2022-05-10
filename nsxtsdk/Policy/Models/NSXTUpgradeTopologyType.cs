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
    /// Recommended topology for migrating NVDS to VDS
    /// </summary>
    [NSXTProperty(Description: @"Recommended topology for migrating NVDS to VDS")]
    public class NSXTUpgradeTopologyType 
    {
        /// <summary>
        /// All resultant VDS mapping for a NVDS after the migration
        /// </summary>
        [JsonProperty(PropertyName = "topology", Required = Required.AllowNull)]
        public IList<NSXTNvdsUpgradeTopologyType> Topology { get; set; }
    }
}
