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
    /// Advanced load balancer DnsRuleActionPoolSwitching object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsRuleActionPoolSwitching object")]
    public class NSXTALBDnsRuleActionPoolSwitchingType 
    {
        /// <summary>
        /// Reference of the pool to serve the passthrough DNS query
        /// which cannot be served locally.
        /// It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_path")]
        [NSXTProperty(IsRequired: false, Description: @"Reference of the pool to serve the passthrough DNS querywhich cannot be served locally.It is a reference to an object of type Pool.")]
        public string? PoolPath { get; set; }
        /// <summary>
        /// Reference of the pool group to serve the passthrough DNS
        /// query which cannot be served locally.
        /// It is a reference to an object of type PoolGroup.
        /// </summary>
        [JsonProperty(PropertyName = "pool_group_path")]
        [NSXTProperty(IsRequired: false, Description: @"Reference of the pool group to serve the passthrough DNSquery which cannot be served locally.It is a reference to an object of type PoolGroup.")]
        public string? PoolGroupPath { get; set; }
    }
}