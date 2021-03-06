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
    /// Interface PIM[Protocol Independent Multicast] configuration parameters.
    /// </summary>
    [NSXTProperty(Description: @"Interface PIM[Protocol Independent Multicast] configuration parameters.")]
    public class NSXTInterfacePimConfigType 
    {
        /// <summary>
        /// PIM hold interval. Ranges from 1 to 630 seconds. hold_interval
        /// should be greater than hello_interval.
        /// If hold interval is not provided then it will be considered as
        /// 3.5 times of hello_interval.
        /// </summary>
        [JsonProperty(PropertyName = "hold_interval")]
        public long? HoldInterval { get; set; }
        /// <summary>
        /// If the flag is set to true - it will enable PIM on
        /// the uplink interface. If the flag is set to false - it will disable
        /// PIM on the uplink interface.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// PIM hello interval. Ranges from 1 to 180 seconds.
        /// </summary>
        [JsonProperty(PropertyName = "hello_interval")]
        public long? HelloInterval { get; set; }
    }
}
