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
    /// Contains a list of Advanced Load Balancer controller node VM deployment requests.
    /// </summary>
    [NSXTProperty(Description: @"Contains a list of Advanced Load Balancer controller node VM deployment requests.")]
    public class NSXTAddALBControllerNodeVMInfoType 
    {
        /// <summary>
        /// Advanced Load Balancer Controller deployment requests to be deployed by NSX.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_requests", Required = Required.AllowNull)]
        public IList<NSXTALBControllerNodeVMDeploymentRequestType> DeploymentRequests { get; set; }
    }
}
