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
    public class NSXTSystemHealthPluginProfileListType : NSXTListResultType
    {
        /// <summary>
        /// System Health plugin list
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTSystemHealthPluginProfileType> Results { get; set; }
        /// <summary>
        /// Total plugin count
        /// </summary>
        [JsonProperty(PropertyName = "result_count", Required = Required.AllowNull)]
        public long ResultCount { get; set; }
    }
}
