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
    public class NSXTServiceInstanceStatusType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "instance_deployment_status")]
        public NSXTServiceDeploymentStatusType InstanceDeploymentStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "configuration_issue")]
        public NSXTSVMConfigureIssueType ConfigurationIssue { get; set; }
        /// <summary>
        /// Id of an instantiation of a registered service.
        /// </summary>
        [JsonProperty(PropertyName = "service_instance_id")]
        public string? ServiceInstanceId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "instance_health_status")]
        public NSXTServiceInstanceHealthStatusType InstanceHealthStatus { get; set; }
    }
}
