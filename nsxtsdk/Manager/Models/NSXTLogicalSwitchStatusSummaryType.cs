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
    public class NSXTLogicalSwitchStatusSummaryType 
    {
        /// <summary>
        /// Timestamp when the data was last updated; unset if data source has never updated the data.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// The total number of logical switches.
        /// </summary>
        [JsonProperty(PropertyName = "total_switches", Required = Required.AllowNull)]
        public long TotalSwitches { get; set; }
        /// <summary>
        /// The filters used to find the logical switches- TransportZone id, LogicalSwitchProfile id or TransportType
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public IList<NSXTFilterType> Filters { get; set; }
        /// <summary>
        /// The number of logical switches that are realized in all transport nodes.
        /// </summary>
        [JsonProperty(PropertyName = "fully_realized_switches", Required = Required.AllowNull)]
        public long FullyRealizedSwitches { get; set; }
    }
}
