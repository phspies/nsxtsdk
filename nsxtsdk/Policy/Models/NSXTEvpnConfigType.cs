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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTEvpnConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "encapsulation_method")]
        public NSXTEvpnEncapConfigType EncapsulationMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "advanced_config")]
        public NSXTEvpnConfigAdvancedConfigType AdvancedConfig { get; set; }
        /// <summary>
        /// In INLINE mode, edge nodes participate both in the BGP EVPN control
        /// plane route exchange and in data path tunneling between edge nodes
        /// and data center gateways. In ROUTE_SERVER mode, edge nodes participate
        /// in the BGP EVPN control plane route exchanges only and do not participate
        /// in the data forwarding, i.e., the data path tunnels are directly
        /// established between the hypervisors and the data center gateways.
        /// DISABLE mode disables EVPN service capability.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTEvpnConfigModeEnumType? Mode { get; set; }
    }
}
