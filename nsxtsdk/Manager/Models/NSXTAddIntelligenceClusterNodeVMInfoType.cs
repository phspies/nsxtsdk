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
    /// Contains a list of NSX-Intelligence cluster node VM deployment requests and optionally
        /// a clustering configuration.
    /// </summary>
    [NSXTProperty(Description: @"Contains a list of NSX-Intelligence cluster node VM deployment requests and optionallya clustering configuration.")]
    public class NSXTAddIntelligenceClusterNodeVMInfoType 
    {
        /// <summary>
        /// Intelligence Cluster node VM deployment requests to be deployed by NSX.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_requests", Required = Required.AllowNull)]
        public IList<NSXTIntelligenceClusterNodeVMDeploymentRequestType> DeploymentRequests { get; set; }
    }
}
