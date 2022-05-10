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
    public class NSXTTransportNodeStatusListResultType : NSXTListResultType
    {
        /// <summary>
        /// List of transport node statuses
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTTransportNodeStatusType> Results { get; set; }
    }
}
