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
    public class NSXTAllocationPoolType 
    {
        /// <summary>
        /// Represents the number of standby services running on the edge node.
        /// </summary>
        [JsonProperty(PropertyName = "standby_service_count")]
        public int? StandbyServiceCount { get; set; }
        /// <summary>
        /// Represents the number of acitve services running on the edge node.
        /// </summary>
        [JsonProperty(PropertyName = "active_service_count")]
        public int? ActiveServiceCount { get; set; }
        /// <summary>
        /// Allocation details of sub-pools configured on edge node.
        /// </summary>
        [JsonProperty(PropertyName = "sub_pools")]
        public IList<NSXTSubPoolType> SubPools { get; set; }
    }
}
