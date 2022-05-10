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
    public class NSXTPolicyServiceInstanceStatisticsType : NSXTResourceType
    {
        /// <summary>
        /// PolicyServiceInsatnce path
        /// </summary>
        [JsonProperty(PropertyName = "service_instance_id")]
        public string? ServiceInstanceId { get; set; }
        /// <summary>
        /// Statistics for the data NICs for all the runtimes associated
        /// with this service instance.
        /// </summary>
        [JsonProperty(PropertyName = "instance_runtime_statistics")]
        public IList<NSXTInstanceRuntimeStatisticType> InstanceRuntimeStatistics { get; set; }
        /// <summary>
        /// Enforcement point path, forward slashes must be escaped using %2F.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_path")]
        public string? EnforcementPointPath { get; set; }
    }
}
