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
    public class NSXTLiveTraceListResultType : NSXTListResultType
    {
        /// <summary>
        /// Livetrace status list
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTLiveTraceStatusType> Results { get; set; }
    }
}
