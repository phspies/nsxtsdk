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
    public class NSXTKubeconfigInfoType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Kubernetes cluster to be used for deployment.
        /// </summary>
        [JsonProperty(PropertyName = "cluster")]
        public string? Cluster { get; set; }
        /// <summary>
        /// Show whether connection to Kubernetes cluster is available or not.
        /// </summary>
        [JsonProperty(PropertyName = "connection_status")]
        public bool? ConnectionStatus { get; set; }
        /// <summary>
        /// Kubeconfig file name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Kubernetes cluster current context to be used for
        /// NSX Application Platform deployment.
        /// </summary>
        [JsonProperty(PropertyName = "current_context")]
        public string? CurrentContext { get; set; }
        /// <summary>
        /// Bundle id of uploaded file.
        /// </summary>
        [JsonProperty(PropertyName = "bundle_id")]
        public string? BundleId { get; set; }
        /// <summary>
        /// User name to access Kubernetes cluster.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string? User { get; set; }
        /// <summary>
        /// Kubernetes api server url.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public string? Server { get; set; }
        /// <summary>
        /// Kubernetes cluster namespace to be used for
        /// NSX Application Platform deployment.
        /// </summary>
        [JsonProperty(PropertyName = "namespace")]
        public string? NamespaceProperty { get; set; }
        /// <summary>
        /// Date and time when Kubernetes cluster user token is going to expire.
        /// </summary>
        [JsonProperty(PropertyName = "expiry")]
        public long? Expiry { get; set; }
    }
}
