// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLogicalPortOperationalStatusType 
    {
        /// <summary>
        /// The id of the logical port
        /// </summary>
        public string? LogicalPortId { get; set; }
        /// <summary>
        /// The Operational status of the logical port
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public NSXTLogicalPortOperationalStatusStatusEnumType Status { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated; unset if data source has never updated the data.
        /// </summary>
        public long? LastUpdateTimestamp { get; set; }
    }
}
