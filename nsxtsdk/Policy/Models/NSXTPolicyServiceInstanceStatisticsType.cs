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
        [NSXTProperty(IsRequired: false, Description: @"PolicyServiceInsatnce path")]
        public string? ServiceInstanceId { get; set; }
        /// <summary>
        /// Statistics for the data NICs for all the runtimes associated
        /// with this service instance.
        /// </summary>
        [JsonProperty(PropertyName = "instance_runtime_statistics")]
        [NSXTProperty(IsRequired: false, Description: @"Statistics for the data NICs for all the runtimes associatedwith this service instance.")]
        public IList<NSXTInstanceRuntimeStatisticType> InstanceRuntimeStatistics { get; set; }
        /// <summary>
        /// Enforcement point path, forward slashes must be escaped using %2F.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_path")]
        [NSXTProperty(IsRequired: false, Description: @"Enforcement point path, forward slashes must be escaped using %2F.")]
        public string? EnforcementPointPath { get; set; }
    }
}
