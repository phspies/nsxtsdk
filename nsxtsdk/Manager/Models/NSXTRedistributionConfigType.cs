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
    public class NSXTRedistributionConfigType : NSXTManagedResourceType
    {
        /// <summary>
        /// Logical router id
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id")]
        public string? LogicalRouterId { get; set; }
        /// <summary>
        /// Flag to enable redistribution for BGP as destination protocol
        /// </summary>
        [JsonProperty(PropertyName = "bgp_enabled")]
        public bool? BgpEnabled { get; set; }
    }
}
