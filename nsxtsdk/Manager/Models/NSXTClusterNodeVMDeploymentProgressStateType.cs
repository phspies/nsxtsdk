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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Deployment progress state of node VM. This Object contains name of current deployment step and overall progress
        /// percentage.
    /// </summary>
    [NSXTProperty(Description: @"Deployment progress state of node VM. This Object contains name of current deployment step and overall progress percentage.")]
    public class NSXTClusterNodeVMDeploymentProgressStateType 
    {
        public NSXTClusterNodeVMDeploymentProgressStateType()
        {
        }
        /// <summary>
        /// Overall progress percentage of deployment completed
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        [NSXTProperty(IsRequired: false, Description: @"Overall progress percentage of deployment completed")]
        public long? Progress { get; set; }
        /// <summary>
        /// Name of the current running step of deployment
        /// </summary>
        [JsonProperty(PropertyName = "current_step_title")]
        [NSXTProperty(IsRequired: false, Description: @"Name of the current running step of deployment")]
        public string? CurrentStepTitle { get; set; }
    }
}
