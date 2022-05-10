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
    public class NSXTClusterNodeVMDeploymentRequestListType : NSXTListResultType
    {
        /// <summary>
        /// Array of existing ClusterNodeVMDeploymentRequests
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        public IList<NSXTClusterNodeVMDeploymentRequestType> Results { get; set; }
    }
}
