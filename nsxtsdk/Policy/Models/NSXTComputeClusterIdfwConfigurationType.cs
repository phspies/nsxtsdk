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
    public class NSXTComputeClusterIdfwConfigurationType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "member", Required = Required.AllowNull)]
        public NSXTPolicyResourceReferenceType Member { get; set; }
        /// <summary>
        /// If set to true, idfw is enabled for this cluster
        /// </summary>
        [JsonProperty(PropertyName = "cluster_idfw_enabled", Required = Required.AllowNull)]
        public bool ClusterIdfwEnabled { get; set; }
    }
}
