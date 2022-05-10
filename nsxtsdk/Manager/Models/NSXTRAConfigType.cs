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
    public class NSXTRAConfigType 
    {
        /// <summary>
        /// Router lifetime value in seconds. A value of 0 indicates the
        /// router is not a default router for the receiving end. Any other value
        /// in this field specifies the lifetime, in seconds, associated with
        /// this router as a default router.
        /// </summary>
        [JsonProperty(PropertyName = "router_lifetime")]
        public long? RouterLifetime { get; set; }
        /// <summary>
        /// Interval between 2 Router advertisement in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "ra_interval")]
        public long? RaInterval { get; set; }
        /// <summary>
        /// The time interval in seconds, in which the prefix is advertised
        /// as preferred.
        /// </summary>
        [JsonProperty(PropertyName = "prefix_preferred_time")]
        public long? PrefixPreferredTime { get; set; }
        /// <summary>
        /// The maximum number of hops through which packets can
        /// pass before being discarded.
        /// </summary>
        [JsonProperty(PropertyName = "hop_limit")]
        public long? HopLimit { get; set; }
        /// <summary>
        /// The time interval in seconds, in which the prefix is advertised
        /// as valid.
        /// </summary>
        [JsonProperty(PropertyName = "prefix_lifetime")]
        public long? PrefixLifetime { get; set; }
        /// <summary>
        /// NDRA Router preference value with MEDIUM as default. If the router_lifetime is 0,
        /// the preference must be set to MEDIUM.
        /// </summary>
        [JsonProperty(PropertyName = "router_preference")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRaconfigRouterPreferenceEnumType? RouterPreference { get; set; }
    }
}
