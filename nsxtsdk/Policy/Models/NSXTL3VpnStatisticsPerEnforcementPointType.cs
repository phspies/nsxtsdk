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
    /// L3Vpn Statistics Per Enforcement Point.
    /// </summary>
    [NSXTProperty(Description: @"L3Vpn Statistics Per Enforcement Point.")]
    public class NSXTL3VpnStatisticsPerEnforcementPointType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTL3VpnStatisticsPerEnforcementPointResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// Policy Path referencing the enforcement point wehere the statistics are fetched.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_path")]
        [NSXTProperty(IsRequired: false, Description: @"Policy Path referencing the enforcement point wehere the statistics are fetched.")]
        public string? EnforcementPointPath { get; set; }
    }
}
