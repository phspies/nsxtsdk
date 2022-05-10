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
    /// Aggregate statistics of all the rules in a security policy for a specific
        /// enforcement point.
    /// </summary>
    [NSXTProperty(Description: @"Aggregate statistics of all the rules in a security policy for a specificenforcement point.")]
    public class NSXTSecurityPolicyStatisticsForEnforcementPointType 
    {
        /// <summary>
        /// Enforcement point to fetch the statistics from.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point")]
        public string? EnforcementPoint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        public NSXTSecurityPolicyStatisticsType Statistics { get; set; }
        /// <summary>
        /// Security Policy statistics for a single container cluster
        /// </summary>
        [JsonProperty(PropertyName = "container_cluster_path")]
        public string? ContainerClusterPath { get; set; }
    }
}
