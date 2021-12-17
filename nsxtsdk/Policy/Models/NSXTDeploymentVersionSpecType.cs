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
    /// Deployment version with chart name
    /// </summary>
    [NSXTProperty(Description: @"Deployment version with chart name")]
    public class NSXTDeploymentVersionSpecType 
    {
        public NSXTDeploymentVersionSpecType()
        {
        }
        /// <summary>
        /// Deployment chart name.
        /// </summary>
        [JsonProperty(PropertyName = "chart_name")]
        [NSXTProperty(IsRequired: false, Description: @"Deployment chart name.")]
        public string? ChartName { get; set; }
        /// <summary>
        /// List of deployment versions.
        /// </summary>
        [JsonProperty(PropertyName = "versions")]
        [NSXTProperty(IsRequired: false, Description: @"List of deployment versions.")]
        public string? Versions { get; set; }
    }
}