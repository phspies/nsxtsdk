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
    /// Multicast PIM configuration.
    /// </summary>
    [NSXTProperty(Description: @"Multicast PIM configuration.")]
    public class NSXTTier0InterfacePimConfigType 
    {
        /// <summary>
        /// PIM hold interval(seconds) at interface level.
        /// </summary>
        [JsonProperty(PropertyName = "hold_interval")]
        public int? HoldInterval { get; set; }
        /// <summary>
        /// enable/disable PIM configuration.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// PIM hello interval(seconds) at interface level.
        /// </summary>
        [JsonProperty(PropertyName = "hello_interval")]
        public int? HelloInterval { get; set; }
    }
}
