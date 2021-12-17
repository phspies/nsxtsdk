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
    /// Aggregate of DNS forwarder status across enforcement points.
    /// </summary>
    [NSXTProperty(Description: @"Aggregate of DNS forwarder status across enforcement points.")]
    public class NSXTAggregateDNSForwarderStatusType 
    {
        public NSXTAggregateDNSForwarderStatusType()
        {
        }
        /// <summary>
        /// List of DNS forwarder status per enforcement point.
        /// </summary>
        [JsonProperty(PropertyName = "status_per_enforcement_point")]
        [NSXTProperty(IsRequired: false, Description: @"List of DNS forwarder status per enforcement point.")]
        public IList<NSXTDNSForwarderStatusPerEnforcementPointType> StatusPerEnforcementPoint { get; set; }
        /// <summary>
        /// String path of the DNS forwarder intent.
        /// </summary>
        [JsonProperty(PropertyName = "intent_path", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"String path of the DNS forwarder intent.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string IntentPath { get; set; }
    }
}
