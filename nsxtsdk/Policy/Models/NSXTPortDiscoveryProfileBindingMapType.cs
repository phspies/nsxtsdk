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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPortDiscoveryProfileBindingMapType : NSXTDiscoveryProfileBindingMapType
    {
        /// <summary>
        /// PolicyPath of associated IP Discovery Profile
        /// </summary>
        [JsonProperty(PropertyName = "ip_discovery_profile_path")]
        [NSXTProperty(IsRequired: false, Description: @"PolicyPath of associated IP Discovery Profile")]
        public string? IpDiscoveryProfilePath { get; set; }
        /// <summary>
        /// PolicyPath of associated Mac Discovery Profile
        /// </summary>
        [JsonProperty(PropertyName = "mac_discovery_profile_path")]
        [NSXTProperty(IsRequired: false, Description: @"PolicyPath of associated Mac Discovery Profile")]
        public string? MacDiscoveryProfilePath { get; set; }
    }
}