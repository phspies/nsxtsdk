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
    /// Pool usage statistics in a pool.
    /// </summary>
    [NSXTProperty(Description: @"Pool usage statistics in a pool.")]
    public class NSXTPoolUsageType 
    {
        /// <summary>
        /// Total number of IDs in a pool
        /// </summary>
        [JsonProperty(PropertyName = "total_ids")]
        public long? TotalIds { get; set; }
        /// <summary>
        /// Total number of allocated IDs in a pool
        /// </summary>
        [JsonProperty(PropertyName = "allocated_ids")]
        public long? AllocatedIds { get; set; }
        /// <summary>
        /// Total number of free IDs in a pool
        /// </summary>
        [JsonProperty(PropertyName = "free_ids")]
        public long? FreeIds { get; set; }
    }
}
