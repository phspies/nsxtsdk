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
    public class NSXTALBControllerNodeVMDeploymentRequestListType : NSXTListResultType
    {
        /// <summary>
        /// Array of existing Advanced Load Balancer Controller Deployment Requests.
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        public IList<NSXTALBControllerNodeVMDeploymentRequestType> Results { get; set; }
    }
}
