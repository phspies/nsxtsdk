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
    /// Datapath memory pool usage value.
    /// </summary>
    [NSXTProperty(Description: @"Datapath memory pool usage value.")]
    public class NSXTEdgeTransportNodeDatapathMemoryPoolUsageType 
    {
        /// <summary>
        /// Percentage of memory pool in use.
        /// </summary>
        [JsonProperty(PropertyName = "usage")]
        public double? Usage { get; set; }
        /// <summary>
        /// Name of the datapath memory pool as available on edge node CLI.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Description of the memory pool.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
    }
}
