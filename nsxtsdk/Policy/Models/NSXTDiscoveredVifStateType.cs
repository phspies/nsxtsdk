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
    /// State of VIFs connected to discovered segment on the TransportNode.
    /// </summary>
    [NSXTProperty(Description: @"State of VIFs connected to discovered segment on the TransportNode.")]
    public class NSXTDiscoveredVifStateType 
    {
        /// <summary>
        /// The state of specific discovered VIF.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDiscoveredVifStateStateEnumType? State { get; set; }
        /// <summary>
        /// Error encountered during segment port creation for the discovered VIF.
        /// </summary>
        [JsonProperty(PropertyName = "error_msg")]
        public string? ErrorMsg { get; set; }
        /// <summary>
        /// Id of discovered VIF.
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
        /// <summary>
        /// SegmentPort path related with discovered VIF.
        /// </summary>
        [JsonProperty(PropertyName = "segment_port_path", Required = Required.AllowNull)]
        public string SegmentPortPath { get; set; }
        /// <summary>
        /// Segment path related with discovered VIF.
        /// </summary>
        [JsonProperty(PropertyName = "segment_path", Required = Required.AllowNull)]
        public string SegmentPath { get; set; }
    }
}
