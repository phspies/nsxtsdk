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
    public class NSXTDeploymentRegistryType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Docker url for containers.
        /// </summary>
        [JsonProperty(PropertyName = "docker_registry", Required = Required.AllowNull)]
        public string DockerRegistry { get; set; }
        /// <summary>
        /// Repo url to access helm chart.
        /// </summary>
        [JsonProperty(PropertyName = "helm_repo", Required = Required.AllowNull)]
        public string HelmRepo { get; set; }
    }
}
