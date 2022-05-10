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
    /// DNS forwarder status per enforcement point.
    /// </summary>
    [NSXTProperty(Description: @"DNS forwarder status per enforcement point.")]
    public class NSXTDNSForwarderStatusPerEnforcementPointType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDnsforwarderStatusPerEnforcementPointResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// Policy path referencing the enforcement point from where the status is fetched.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_path")]
        public string? EnforcementPointPath { get; set; }
    }
}
