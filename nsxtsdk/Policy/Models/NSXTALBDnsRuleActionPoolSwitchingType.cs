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
        public string? PoolPath { get; set; }
        /// <summary>
        /// Reference of the pool group to serve the passthrough DNS
        /// query which cannot be served locally.
        /// It is a reference to an object of type PoolGroup.
        /// </summary>
        [JsonProperty(PropertyName = "pool_group_path")]
        public string? PoolGroupPath { get; set; }
    }
}
