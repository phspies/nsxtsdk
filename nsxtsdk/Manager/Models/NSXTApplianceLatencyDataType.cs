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
    public class NSXTApplianceLatencyDataType : NSXTResourceType
    {
        /// <summary>
        /// Latency Data list.
        /// </summary>
        [JsonProperty(PropertyName = "latency_data")]
        public IList<NSXTApplianceLatencyDataItemType> LatencyData { get; set; }
        /// <summary>
        /// Display the Appliance id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Timestamp of last modification.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long? Timestamp { get; set; }
        /// <summary>
        /// Display the appliance name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
