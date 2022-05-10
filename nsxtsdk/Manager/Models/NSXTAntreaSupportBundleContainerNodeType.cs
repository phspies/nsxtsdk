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
    public class NSXTAntreaSupportBundleContainerNodeType : NSXTSupportBundleContainerNodeType
    {
        /// <summary>
        /// List of AntreaContainerClusterNodes identifying container clusters and their nodes
        /// </summary>
        [JsonProperty(PropertyName = "clusters")]
        public IList<NSXTAntreaContainerClusterNodeType> Clusters { get; set; }
    }
}
