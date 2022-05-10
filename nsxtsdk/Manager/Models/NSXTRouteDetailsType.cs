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
    /// BGP route details.
    /// </summary>
    [NSXTProperty(Description: @"BGP route details.")]
    public class NSXTRouteDetailsType 
    {
        /// <summary>
        /// BGP Multi Exit Discriminator attribute.
        /// </summary>
        [JsonProperty(PropertyName = "med")]
        public long? Med { get; set; }
        /// <summary>
        /// Next hop IP address.
        /// </summary>
        [JsonProperty(PropertyName = "next_hop")]
        public string? NextHop { get; set; }
        /// <summary>
        /// CIDR network address.
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        public string? Network { get; set; }
        /// <summary>
        /// BGP Weight attribute.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public long? Weight { get; set; }
        /// <summary>
        /// BGP Local Preference attribute.
        /// </summary>
        [JsonProperty(PropertyName = "local_pref")]
        public long? LocalPref { get; set; }
        /// <summary>
        /// BGP AS path attribute.
        /// </summary>
        [JsonProperty(PropertyName = "as_path")]
        public string? AsPath { get; set; }
    }
}
