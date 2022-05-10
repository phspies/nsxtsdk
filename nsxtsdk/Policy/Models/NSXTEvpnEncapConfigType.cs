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
    public class NSXTEvpnEncapConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// vni pool path
        /// </summary>
        [JsonProperty(PropertyName = "vni_pool_path")]
        public string? VniPoolPath { get; set; }
        /// <summary>
        /// EVPN tenant config path
        /// </summary>
        [JsonProperty(PropertyName = "evpn_tenant_config_path")]
        public string? EvpnTenantConfigPath { get; set; }
    }
}
