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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTFederationNodeSummaryType : NSXTResourceType
    {
        /// <summary>
        /// Number of nodes of the type and at the component version.
        /// </summary>
        [JsonProperty(PropertyName = "node_count")]
        public int? NodeCount { get; set; }
        /// <summary>
        /// Component version
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
    }
}
