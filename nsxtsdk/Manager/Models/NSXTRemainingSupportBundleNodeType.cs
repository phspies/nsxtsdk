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
    public class NSXTRemainingSupportBundleNodeType 
    {
        /// <summary>
        /// Status of node
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRemainingSupportBundleNodeStatusEnumType? Status { get; set; }
        /// <summary>
        /// Display name of node
        /// </summary>
        [JsonProperty(PropertyName = "node_display_name")]
        public string? NodeDisplayName { get; set; }
        /// <summary>
        /// UUID of node
        /// </summary>
        [JsonProperty(PropertyName = "node_id")]
        public string? NodeId { get; set; }
    }
}
