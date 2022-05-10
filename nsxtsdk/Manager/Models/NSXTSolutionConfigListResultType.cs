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
    public class NSXTSolutionConfigListResultType : NSXTListResultType
    {
        /// <summary>
        /// List of the Solution Config.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTSolutionConfigType> Results { get; set; }
    }
}
