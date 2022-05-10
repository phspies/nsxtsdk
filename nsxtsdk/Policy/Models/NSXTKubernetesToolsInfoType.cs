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
    public class NSXTKubernetesToolsInfoType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Show compatibility flag, whether kubectl client version is compatible with Kubernetes api server version. kubectl is
        /// supported within one minor version (older or newer) of kube-apiserver.
        /// </summary>
        [JsonProperty(PropertyName = "compatible")]
        public bool? Compatible { get; set; }
        /// <summary>
        /// kubectl client version.
        /// </summary>
        [JsonProperty(PropertyName = "client_version")]
        public string? ClientVersion { get; set; }
        /// <summary>
        /// Kubernetes api server version.
        /// </summary>
        [JsonProperty(PropertyName = "server_version")]
        public string? ServerVersion { get; set; }
    }
}
