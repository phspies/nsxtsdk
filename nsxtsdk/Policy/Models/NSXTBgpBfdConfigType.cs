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
    /// BFD configuration for BGP peers
    /// </summary>
    [NSXTProperty(Description: @"BFD configuration for BGP peers")]
    public class NSXTBgpBfdConfigType 
    {
        /// <summary>
        /// Declare dead multiple.
        /// Number of times heartbeat packet is missed before BFD declares the
        /// neighbor is down.
        /// </summary>
        [JsonProperty(PropertyName = "multiple")]
        public int? Multiple { get; set; }
        /// <summary>
        /// Time interval between heartbeat packets in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public int? Interval { get; set; }
        /// <summary>
        /// Flag to enable BFD cofiguration.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
    }
}
