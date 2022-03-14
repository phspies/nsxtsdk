// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public long? Progress { get; set; }
        /// <summary>
        /// Deployment step title
        /// </summary>
        public string? CurrentStepTitle { get; set; }
    }
}
