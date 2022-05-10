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
    public class NSXTSIDataCounterType 
    {
        /// <summary>
        /// The total packets or bytes
        /// </summary>
        [JsonProperty(PropertyName = "total", Required = Required.AllowNull)]
        public long Total { get; set; }
        /// <summary>
        /// The multicast and broadcast packets or bytes
        /// </summary>
        [JsonProperty(PropertyName = "multicast_broadcast")]
        public long? MulticastBroadcast { get; set; }
        /// <summary>
        /// The dropped packets or bytes
        /// </summary>
        [JsonProperty(PropertyName = "dropped")]
        public long? Dropped { get; set; }
    }
}
