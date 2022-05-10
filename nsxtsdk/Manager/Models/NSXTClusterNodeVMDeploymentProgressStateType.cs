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
    /// Deployment progress state of node VM. This Object contains name of current deployment step and overall progress
        /// percentage.
    /// </summary>
    [NSXTProperty(Description: @"Deployment progress state of node VM. This Object contains name of current deployment step and overall progress percentage.")]
    public class NSXTClusterNodeVMDeploymentProgressStateType 
    {
        /// <summary>
        /// Overall progress percentage of deployment completed
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public long? Progress { get; set; }
        /// <summary>
        /// Name of the current running step of deployment
        /// </summary>
        [JsonProperty(PropertyName = "current_step_title")]
        public string? CurrentStepTitle { get; set; }
    }
}
