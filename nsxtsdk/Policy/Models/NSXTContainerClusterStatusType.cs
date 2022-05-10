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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTContainerClusterStatusType 
    {
        /// <summary>
        /// Display the container cluster status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTContainerClusterStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Display the cluster check interval in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public int? Interval { get; set; }
        /// <summary>
        /// Identifier of the container cluster.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_id")]
        public string? ClusterId { get; set; }
        /// <summary>
        /// Detail information on status.
        /// </summary>
        [JsonProperty(PropertyName = "detail")]
        public string? Detail { get; set; }
    }
}
