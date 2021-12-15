// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
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
        [NSXTProperty(IsRequired: false, Description: @"BGP Multi Exit Discriminator attribute.")]
        public long? Med { get; set; }
        /// <summary>
        /// Next hop IP address.
        /// </summary>
        [JsonProperty(PropertyName = "next_hop")]
        [NSXTProperty(IsRequired: false, Description: @"Next hop IP address.")]
        public string? NextHop { get; set; }
        /// <summary>
        /// CIDR network address.
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        [NSXTProperty(IsRequired: false, Description: @"CIDR network address.")]
        public string? Network { get; set; }
        /// <summary>
        /// BGP Weight attribute.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        [NSXTProperty(IsRequired: false, Description: @"BGP Weight attribute.")]
        public long? Weight { get; set; }
        /// <summary>
        /// BGP Local Preference attribute.
        /// </summary>
        [JsonProperty(PropertyName = "local_pref")]
        [NSXTProperty(IsRequired: false, Description: @"BGP Local Preference attribute.")]
        public long? LocalPref { get; set; }
        /// <summary>
        /// BGP AS path attribute.
        /// </summary>
        [JsonProperty(PropertyName = "as_path")]
        [NSXTProperty(IsRequired: false, Description: @"BGP AS path attribute.")]
        public string? AsPath { get; set; }
    }
}