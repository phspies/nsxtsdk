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
    public class NSXTClusterProfileListResultType : NSXTListResultType
    {
        /// <summary>
        /// Cluster Profile Results
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTClusterProfileType> Results { get; set; }
    }
}
