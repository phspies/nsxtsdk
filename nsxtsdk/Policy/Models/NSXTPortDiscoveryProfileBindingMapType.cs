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
    public class NSXTPortDiscoveryProfileBindingMapType : NSXTDiscoveryProfileBindingMapType
    {
        /// <summary>
        /// PolicyPath of associated IP Discovery Profile
        /// </summary>
        [JsonProperty(PropertyName = "ip_discovery_profile_path")]
        public string? IpDiscoveryProfilePath { get; set; }
        /// <summary>
        /// PolicyPath of associated Mac Discovery Profile
        /// </summary>
        [JsonProperty(PropertyName = "mac_discovery_profile_path")]
        public string? MacDiscoveryProfilePath { get; set; }
    }
}
