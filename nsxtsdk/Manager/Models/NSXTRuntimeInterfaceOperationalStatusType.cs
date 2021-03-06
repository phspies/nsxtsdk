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
    public class NSXTRuntimeInterfaceOperationalStatusType 
    {
        /// <summary>
        /// The Operational status of the interface
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRuntimeInterfaceOperationalStatusStatusEnumType Status { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated; unset if data source has never updated the data.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Index of the interface
        /// </summary>
        [JsonProperty(PropertyName = "interface_index")]
        public long? InterfaceIndex { get; set; }
    }
}
