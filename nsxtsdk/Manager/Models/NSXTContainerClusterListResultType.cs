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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTContainerClusterListResultType : NSXTListResultType
    {
        /// <summary>
        /// List of Container Clusters
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        public IList<NSXTContainerClusterType> Results { get; set; }
    }
}
