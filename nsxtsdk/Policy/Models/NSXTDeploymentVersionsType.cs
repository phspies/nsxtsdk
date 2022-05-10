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
    /// Different NSX Application Platform deployment versions.
    /// </summary>
    [NSXTProperty(Description: @"Different NSX Application Platform deployment versions.")]
    public class NSXTDeploymentVersionsType 
    {
        /// <summary>
        /// List of deployment versions.
        /// </summary>
        [JsonProperty(PropertyName = "versions")]
        public IList<NSXTDeploymentVersionSpecType> Versions { get; set; }
    }
}
