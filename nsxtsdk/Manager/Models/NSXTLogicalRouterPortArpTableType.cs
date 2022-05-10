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
    public class NSXTLogicalRouterPortArpTableType : NSXTListResultType
    {
        /// <summary>
        /// Timestamp when the data was last updated; unset if data source has never updated the data.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTLogicalRouterPortArpEntryType> Results { get; set; }
        /// <summary>
        /// The ID of the logical router port
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_port_id", Required = Required.AllowNull)]
        public string LogicalRouterPortId { get; set; }
    }
}
