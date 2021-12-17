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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLogicalSwitchStatusSummaryType 
    {
        public NSXTLogicalSwitchStatusSummaryType()
        {
        }
        /// <summary>
        /// Timestamp when the data was last updated; unset if data source has never updated the data.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp when the data was last updated; unset if data source has never updated the data.")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// The total number of logical switches.
        /// </summary>
        [JsonProperty(PropertyName = "total_switches", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The total number of logical switches.")]
        [System.ComponentModel.DataAnnotations.Required]
        public long TotalSwitches { get; set; }
        /// <summary>
        /// The filters used to find the logical switches- TransportZone id, LogicalSwitchProfile id or TransportType
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        [NSXTProperty(IsRequired: false, Description: @"The filters used to find the logical switches- TransportZone id, LogicalSwitchProfile id or TransportType")]
        public IList<NSXTFilterType> Filters { get; set; }
        /// <summary>
        /// The number of logical switches that are realized in all transport nodes.
        /// </summary>
        [JsonProperty(PropertyName = "fully_realized_switches", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The number of logical switches that are realized in all transport nodes.")]
        [System.ComponentModel.DataAnnotations.Required]
        public long FullyRealizedSwitches { get; set; }
    }
}
