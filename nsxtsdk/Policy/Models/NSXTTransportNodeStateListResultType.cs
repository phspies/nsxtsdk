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
    public class NSXTTransportNodeStateListResultType : NSXTListResultType
    {
        /// <summary>
        /// Transport Node State Results
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTTransportNodeStateType> Results { get; set; }
    }
}
