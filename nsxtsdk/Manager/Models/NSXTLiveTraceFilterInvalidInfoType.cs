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
    public class NSXTLiveTraceFilterInvalidInfoType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public NSXTLiveTraceFilterDataType Filter { get; set; }
        /// <summary>
        /// The description of why the filter is rejected by the transport node.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
    }
}
