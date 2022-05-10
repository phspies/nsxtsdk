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
    public class NSXTContainerClusterSummaryType : NSXTManagedResourceType
    {
        /// <summary>
        /// Display the container cluster name
        /// </summary>
        [JsonProperty(PropertyName = "cluster_name", Required = Required.AllowNull)]
        public string ClusterName { get; set; }
        /// <summary>
        /// Display the container cluster status.
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTContainerClusterSummaryStatusEnumType Status { get; set; }
        /// <summary>
        /// Container cluster type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTContainerClusterSummaryTypeEnumType? Type { get; set; }
        /// <summary>
        /// Detail information on status.
        /// </summary>
        [JsonProperty(PropertyName = "detail")]
        public string? Detail { get; set; }
        /// <summary>
        /// Identifier of the container cluster.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_id")]
        public string? ClusterId { get; set; }
    }
}
