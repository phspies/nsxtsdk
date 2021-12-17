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
    public class NSXTContainerClusterSummaryType : NSXTManagedResourceType
    {
        public NSXTContainerClusterSummaryType()
        {
        }
        /// <summary>
        /// Display the container cluster name
        /// </summary>
        [JsonProperty(PropertyName = "cluster_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Display the container cluster name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ClusterName { get; set; }
        /// <summary>
        /// Display the container cluster status.
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Display the container cluster status.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTContainerClusterSummaryStatusEnumType Status { get; set; }
        /// <summary>
        /// Container cluster type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [NSXTProperty(IsRequired: false, Description: @"Container cluster type.")]
        public NSXTContainerClusterSummaryTypeEnumType? Type { get; set; }
        /// <summary>
        /// Detail information on status.
        /// </summary>
        [JsonProperty(PropertyName = "detail")]
        [NSXTProperty(IsRequired: false, Description: @"Detail information on status.")]
        public string? Detail { get; set; }
        /// <summary>
        /// Identifier of the container cluster.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_id")]
        [NSXTProperty(IsRequired: false, Description: @"Identifier of the container cluster.")]
        public string? ClusterId { get; set; }
    }
}
