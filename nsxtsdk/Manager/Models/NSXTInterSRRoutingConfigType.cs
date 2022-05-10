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
    /// Inter SR IBGP configuration
    /// </summary>
    [NSXTProperty(Description: @"Inter SR IBGP configuration")]
    public class NSXTInterSRRoutingConfigType 
    {
        /// <summary>
        /// While creation of BGP config this flag will be set to
        /// - true for Tier0 logical router with Active-Active high-availability
        /// mode
        /// - false for Tier0 logical router with Active-Standby high-availability
        /// mode.
        /// User can change this value while updating inter-sr config.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
    }
}
