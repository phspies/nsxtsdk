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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTRuntimeInterfaceStatisticsType : NSXTSIAggregatedDataCounterExType
    {
        /// <summary>
        /// Timestamp when the data was last updated; unset if data source has never updated the data.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp when the data was last updated; unset if data source has never updated the data.")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Index of the interface
        /// </summary>
        [JsonProperty(PropertyName = "interface_index")]
        [NSXTProperty(IsRequired: false, Description: @"Index of the interface")]
        public long? InterfaceIndex { get; set; }
    }
}
