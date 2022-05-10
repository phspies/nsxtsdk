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
    /// L3Vpn Statistics Per Enforcement Point.
    /// </summary>
    [NSXTProperty(Description: @"L3Vpn Statistics Per Enforcement Point.")]
    public class NSXTL3VpnStatisticsPerEnforcementPointType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL3VpnStatisticsPerEnforcementPointResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// Policy Path referencing the enforcement point wehere the statistics are fetched.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_path")]
        public string? EnforcementPointPath { get; set; }
    }
}
