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
    public class NSXTCloudNativeDeploymentConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "kubeconf_info")]
        public NSXTKubeconfigInfoType KubeconfInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "deployment_action")]
        public NSXTCloudNativeDeploymentActionType DeploymentAction { get; set; }
        /// <summary>
        /// Deployment version in use.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
        /// <summary>
        /// Unique id to identify kubernetes guest cluster.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_id")]
        public string? ClusterId { get; set; }
        /// <summary>
        /// Kubernetes storage class
        /// </summary>
        [JsonProperty(PropertyName = "storage_class")]
        public string? StorageClass { get; set; }
    }
}
