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
    /// Deployment progress state of transport node. Object has current deployment step title and progress in percentage.
    /// </summary>
    [NSXTProperty(Description: @"Deployment progress state of transport node. Object has current deployment step title and progress in percentage.")]
    public class NSXTTransportNodeDeploymentProgressStateType 
    {
        /// <summary>
        /// Percentage of deployment completed
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public long? Progress { get; set; }
        /// <summary>
        /// Deployment step title
        /// </summary>
        [JsonProperty(PropertyName = "current_step_title")]
        public string? CurrentStepTitle { get; set; }
    }
}
