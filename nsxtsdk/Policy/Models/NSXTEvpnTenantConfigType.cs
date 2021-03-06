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
    public class NSXTEvpnTenantConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Policy path to transport zone. Only overlay transport zone is supported.
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_path", Required = Required.AllowNull)]
        public string TransportZonePath { get; set; }
        /// <summary>
        /// This property specifies a mapping spec of incoming Evpn tenant vlan-ids to VXLAN VNIs used for overlay
        /// transmission to Physical-Gateways used by vRouters.
        /// </summary>
        [JsonProperty(PropertyName = "mappings", Required = Required.AllowNull)]
        public IList<NSXTVlanVniRangePairType> Mappings { get; set; }
        /// <summary>
        /// Policy path to the vni pool used for Evpn in ROUTE-SERVER mode.
        /// </summary>
        [JsonProperty(PropertyName = "vni_pool_path", Required = Required.AllowNull)]
        public string VniPoolPath { get; set; }
    }
}
