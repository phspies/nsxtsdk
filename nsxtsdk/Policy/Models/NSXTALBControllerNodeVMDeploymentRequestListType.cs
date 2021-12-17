// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTALBControllerNodeVMDeploymentRequestListType : NSXTListResultType
    {
        public NSXTALBControllerNodeVMDeploymentRequestListType()
        {
        }
        /// <summary>
        /// Array of existing Advanced Load Balancer Controller Deployment Requests.
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Array of existing Advanced Load Balancer Controller Deployment Requests.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTALBControllerNodeVMDeploymentRequestType> Results { get; set; }
    }
}