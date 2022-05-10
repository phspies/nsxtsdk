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
    /// Used to provide the deployment spec for Upgrade.
    /// </summary>
    [NSXTProperty(Description: @"Used to provide the deployment spec for Upgrade.")]
    public class NSXTDeploymentSpecNameType 
    {
        /// <summary>
        /// This indicates the deployment spec.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_spec_name")]
        public string? DeploymentSpecName { get; set; }
    }
}
