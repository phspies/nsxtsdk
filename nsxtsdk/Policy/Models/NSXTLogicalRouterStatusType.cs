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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLogicalRouterStatusType 
    {
        /// <summary>
        /// Timestamp when the data was last updated; unset if data source has never updated the data.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// The id of the logical router
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id", Required = Required.AllowNull)]
        public string LogicalRouterId { get; set; }
        /// <summary>
        /// Per Node Status
        /// </summary>
        [JsonProperty(PropertyName = "per_node_status")]
        public IList<NSXTLogicalRouterStatusPerNodeType> PerNodeStatus { get; set; }
        /// <summary>
        /// Egress mode for the logical router at given mode
        /// </summary>
        [JsonProperty(PropertyName = "locale_operation_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLogicalRouterStatusLocaleOperationModeEnumType? LocaleOperationMode { get; set; }
    }
}
