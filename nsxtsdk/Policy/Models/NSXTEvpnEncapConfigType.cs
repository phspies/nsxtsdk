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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTEvpnEncapConfigType : NSXTPolicyConfigResourceType
    {
        public NSXTEvpnEncapConfigType()
        {
        }
        /// <summary>
        /// vni pool path
        /// </summary>
        [JsonProperty(PropertyName = "vni_pool_path")]
        [NSXTProperty(IsRequired: false, Description: @"vni pool path")]
        public string? VniPoolPath { get; set; }
        /// <summary>
        /// EVPN tenant config path
        /// </summary>
        [JsonProperty(PropertyName = "evpn_tenant_config_path")]
        [NSXTProperty(IsRequired: false, Description: @"EVPN tenant config path")]
        public string? EvpnTenantConfigPath { get; set; }
    }
}
