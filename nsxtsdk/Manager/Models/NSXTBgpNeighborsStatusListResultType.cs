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
    public class NSXTBgpNeighborsStatusListResultType : NSXTListResultType
    {
        /// <summary>
        /// Name of the logical router
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_name")]
        public string? LogicalRouterName { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated, unset if data source has never updated the data.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Logical router id
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id")]
        public string? LogicalRouterId { get; set; }
        /// <summary>
        /// Status of BGP neighbors of the logical router
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTBgpNeighborStatusType> Results { get; set; }
    }
}
