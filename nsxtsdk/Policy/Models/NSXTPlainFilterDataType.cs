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
    public class NSXTPlainFilterDataType : NSXTLiveTraceFilterDataType
    {
        /// <summary>
        /// Extended RCF rule for packet filter
        /// </summary>
        [JsonProperty(PropertyName = "extend_filter")]
        public string? ExtendFilter { get; set; }
        /// <summary>
        /// Basic RCF rule for packet filter
        /// </summary>
        [JsonProperty(PropertyName = "basic_filter")]
        public string? BasicFilter { get; set; }
    }
}
