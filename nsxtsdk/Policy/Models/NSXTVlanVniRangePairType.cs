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
    /// Vlan-Vni mapping pair resource in EvpnTenantConfig for ROUTE-SERVER Evpn mode
    /// </summary>
    [NSXTProperty(Description: @"Vlan-Vni mapping pair resource in EvpnTenantConfig for ROUTE-SERVER Evpn mode")]
    public class NSXTVlanVniRangePairType 
    {
        /// <summary>
        /// List of VNI ids and VNI ranges (specified with '-'). The vni id is used for VXLAN transmission for a given tenant Vlan
        /// ID in ROUTE-SERVER Evpn.
        /// </summary>
        [JsonProperty(PropertyName = "vnis", Required = Required.AllowNull)]
        public string Vnis { get; set; }
        /// <summary>
        /// List of VLAN ids and VLAN ranges (specified with '-').
        /// </summary>
        [JsonProperty(PropertyName = "vlans", Required = Required.AllowNull)]
        public string Vlans { get; set; }
    }
}
