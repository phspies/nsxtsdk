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
    /// Contains a list of cluster node VM deployment requests and optionally
        /// a clustering configuration.
    /// </summary>
    [NSXTProperty(Description: @"Contains a list of cluster node VM deployment requests and optionallya clustering configuration.")]
    public class NSXTAddClusterNodeVMInfoType 
    {
        /// <summary>
        /// Cluster node VM deployment requests to be deployed by the Manager.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_requests", Required = Required.AllowNull)]
        public IList<NSXTClusterNodeVMDeploymentRequestType> DeploymentRequests { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "clustering_config")]
        public NSXTClusteringConfigType ClusteringConfig { get; set; }
    }
}
