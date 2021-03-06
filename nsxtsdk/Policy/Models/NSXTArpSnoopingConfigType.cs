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
    /// Contains ARP snooping related configuration.
    /// </summary>
    [NSXTProperty(Description: @"Contains ARP snooping related configuration.")]
    public class NSXTArpSnoopingConfigType 
    {
        /// <summary>
        /// Number of arp snooped IP addresses
        /// Indicates the number of arp snooped IP addresses to be remembered
        /// per LogicalPort. Decreasing this value, will retain the latest
        /// bindings from the existing list of address bindings. Increasing this
        /// value will retain existing bindings and also learn any new address
        /// bindings discovered on the port until the new limit is reached.
        /// </summary>
        [JsonProperty(PropertyName = "arp_binding_limit")]
        public int? ArpBindingLimit { get; set; }
        /// <summary>
        /// Indicates whether ARP snooping is enabled
        /// </summary>
        [JsonProperty(PropertyName = "arp_snooping_enabled")]
        public bool? ArpSnoopingEnabled { get; set; }
    }
}
