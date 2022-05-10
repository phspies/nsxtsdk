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
    /// Parameters for nvds upgrade precheck
    /// </summary>
    [NSXTProperty(Description: @"Parameters for nvds upgrade precheck")]
    public class NSXTPrecheckParametersType 
    {
        /// <summary>
        /// Cluster ID list for nvds upgrade precheck
        /// </summary>
        [JsonProperty(PropertyName = "cluster_ids")]
        public IList<string> ClusterIds { get; set; }
    }
}
