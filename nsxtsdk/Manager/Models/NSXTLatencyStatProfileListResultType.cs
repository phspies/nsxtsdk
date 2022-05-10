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
    public class NSXTLatencyStatProfileListResultType : NSXTListResultType
    {
        /// <summary>
        /// Latency stat profile list.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTLatencyStatProfileType> Results { get; set; }
    }
}
