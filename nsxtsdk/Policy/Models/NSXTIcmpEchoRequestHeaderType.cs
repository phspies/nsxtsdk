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
    public class NSXTIcmpEchoRequestHeaderType 
    {
        /// <summary>
        /// ICMP id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long? Id { get; set; }
        /// <summary>
        /// ICMP sequence number
        /// </summary>
        [JsonProperty(PropertyName = "sequence")]
        public long? Sequence { get; set; }
    }
}
