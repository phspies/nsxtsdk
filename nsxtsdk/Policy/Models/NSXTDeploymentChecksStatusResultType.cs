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
    /// List of pre/post check.
    /// </summary>
    [NSXTProperty(Description: @"List of pre/post check.")]
    public class NSXTDeploymentChecksStatusResultType 
    {
        /// <summary>
        /// Array of pre/post deployment checks.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTDeploymentChecksStatusType> Results { get; set; }
    }
}
