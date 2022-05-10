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
    /// Statistics for data NICs on an instance runtime
    /// </summary>
    [NSXTProperty(Description: @"Statistics for data NICs on an instance runtime")]
    public class NSXTInstanceRuntimeStatisticType 
    {
        /// <summary>
        /// List of statistics for all data NICs on a runtime.
        /// </summary>
        [JsonProperty(PropertyName = "interface_statistics")]
        public IList<NSXTRuntimeInterfaceStatisticsType> InterfaceStatistics { get; set; }
        /// <summary>
        /// Name of the instance runtime
        /// </summary>
        [JsonProperty(PropertyName = "runtime_name")]
        public string? RuntimeName { get; set; }
        /// <summary>
        /// Specifies whether statistics are for primary runtime.
        /// </summary>
        [JsonProperty(PropertyName = "primary_runtime_stats")]
        public bool? PrimaryRuntimeStats { get; set; }
        /// <summary>
        /// Id of the instance runtime
        /// </summary>
        [JsonProperty(PropertyName = "runtime_id")]
        public string? RuntimeId { get; set; }
    }
}
