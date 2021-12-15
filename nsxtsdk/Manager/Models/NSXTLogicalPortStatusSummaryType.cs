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
    public class NSXTLogicalPortStatusSummaryType 
    {
        /// <summary>
        /// The total number of logical ports.
        /// </summary>
        [JsonProperty(PropertyName = "total_ports", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The total number of logical ports.")]
        [System.ComponentModel.DataAnnotations.Required]
        public long TotalPorts { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated; unset if data source has never updated the data.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp when the data was last updated; unset if data source has never updated the data.")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// The number of logical ports whose Operational status is UP
        /// </summary>
        [JsonProperty(PropertyName = "up_ports", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The number of logical ports whose Operational status is UP")]
        [System.ComponentModel.DataAnnotations.Required]
        public long UpPorts { get; set; }
        /// <summary>
        /// The filters used to find the logical ports- TransportZone id, LogicalSwitch id or LogicalSwitchProfile id
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        [NSXTProperty(IsRequired: false, Description: @"The filters used to find the logical ports- TransportZone id, LogicalSwitch id or LogicalSwitchProfile id")]
        public IList<NSXTFilterType> Filters { get; set; }
    }
}