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
    /// Deployment version with chart name
    /// </summary>
    [NSXTProperty(Description: @"Deployment version with chart name")]
    public class NSXTDeploymentVersionSpecType 
    {
        /// <summary>
        /// Deployment chart name.
        /// </summary>
        [JsonProperty(PropertyName = "chart_name")]
        public string? ChartName { get; set; }
        /// <summary>
        /// List of deployment versions.
        /// </summary>
        [JsonProperty(PropertyName = "versions")]
        public string? Versions { get; set; }
    }
}
