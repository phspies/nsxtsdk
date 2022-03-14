// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Overrides the router advertisement attributes for the
        /// IPv6 prefixes.
    /// </summary>
    [NSXTProperty(Description: @"Overrides the router advertisement attributes for theIPv6 prefixes.")]
    public class NSXTNDRAPrefixConfigType 
    {
        /// <summary>
        /// Override the neighbor discovery prefix preferred time and
        /// prefix valid time for the subnet on uplink port whose
        /// network matches with the network address of CIDR specified
        /// in network_prefix.
        /// </summary>
        [JsonProperty(PropertyName = "network_prefix", Required = Required.AllowNull)]
        public string NetworkPrefix { get; set; }
        /// <summary>
        /// The time interval in seconds, in which the prefix is advertised
        /// as valid.
        /// </summary>
        public long? PrefixValidTime { get; set; }
        /// <summary>
        /// The time interval in seconds, in which the prefix is advertised
        /// as preferred.
        /// </summary>
        public long? PrefixPreferredTime { get; set; }
    }
}
