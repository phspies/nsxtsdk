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
    /// Contain optional configuration for deployment.
    /// </summary>
    [NSXTProperty(Description: @"Contain optional configuration for deployment.")]
    public class NSXTAdvanceServiceConfigType 
    {
        /// <summary>
        /// FQDN to access deployment pod.
        /// </summary>
        [JsonProperty(PropertyName = "service_name")]
        public string? ServiceName { get; set; }
        /// <summary>
        /// Filename of uploaded Kubernetes tools
        /// </summary>
        [JsonProperty(PropertyName = "kubectl_tool")]
        public string? KubectlTool { get; set; }
    }
}
