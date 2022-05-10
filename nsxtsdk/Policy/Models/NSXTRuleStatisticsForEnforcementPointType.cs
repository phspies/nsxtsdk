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
    /// Rule statistics for a specfic enforcement point.
    /// </summary>
    [NSXTProperty(Description: @"Rule statistics for a specfic enforcement point.")]
    public class NSXTRuleStatisticsForEnforcementPointType 
    {
        /// <summary>
        /// Rule statistics for a single enforcement point
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point")]
        public string? EnforcementPoint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        public NSXTRuleStatisticsType Statistics { get; set; }
        /// <summary>
        /// Rule statistics for a single container cluster
        /// </summary>
        [JsonProperty(PropertyName = "container_cluster_path")]
        public string? ContainerClusterPath { get; set; }
    }
}
