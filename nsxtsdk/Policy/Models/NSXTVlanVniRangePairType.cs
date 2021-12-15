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
        [NSXTProperty(IsRequired: true, Description: @"List of VNI ids and VNI ranges (specified with &apos;-&apos;). The vni id is used for VXLAN transmission for a given tenant Vlan ID in ROUTE-SERVER Evpn.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Vnis { get; set; }
        /// <summary>
        /// List of VLAN ids and VLAN ranges (specified with '-').
        /// </summary>
        [JsonProperty(PropertyName = "vlans", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"List of VLAN ids and VLAN ranges (specified with &apos;-&apos;).")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Vlans { get; set; }
    }
}