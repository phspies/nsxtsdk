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
    /// DNS forwarder nslookup answer per enforcement point.
    /// </summary>
    [NSXTProperty(Description: @"DNS forwarder nslookup answer per enforcement point.")]
    public class NSXTPolicyDnsAnswerPerEnforcementPointType 
    {
        /// <summary>
        /// Resource type of the DNS forwarder nslookup answer.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyDnsAnswerPerEnforcementPointResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// Policy path referencing the enforcement point from where the
        /// DNS forwarder nslookup answer is fetched.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_path")]
        public string? EnforcementPointPath { get; set; }
    }
}
