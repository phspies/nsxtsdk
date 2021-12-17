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
    /// DNS forwarder statistics per enforcement point.
    /// </summary>
    [NSXTProperty(Description: @"DNS forwarder statistics per enforcement point.")]
    public class NSXTDNSForwarderStatisticsPerEnforcementPointType 
    {
        public NSXTDNSForwarderStatisticsPerEnforcementPointType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTDnsforwarderStatisticsPerEnforcementPointResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// Policy path referencing the enforcement point from where the statistics are fetched.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_path")]
        [NSXTProperty(IsRequired: false, Description: @"Policy path referencing the enforcement point from where the statistics are fetched.")]
        public string? EnforcementPointPath { get; set; }
    }
}
