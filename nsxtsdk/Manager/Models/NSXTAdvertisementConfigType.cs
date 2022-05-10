using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTAdvertisementConfigType : NSXTManagedResourceType
    {
        /// <summary>
        /// Flag to advertise all connected routes
        /// </summary>
        [JsonProperty(PropertyName = "advertise_nsx_connected_routes")]
        public bool? AdvertiseNsxConnectedRoutes { get; set; }
        /// <summary>
        /// Flag to advertise lb vip ips
        /// </summary>
        [JsonProperty(PropertyName = "advertise_lb_vip")]
        public bool? AdvertiseLbVip { get; set; }
        /// <summary>
        /// Flag to advertise all static routes
        /// </summary>
        [JsonProperty(PropertyName = "advertise_static_routes")]
        public bool? AdvertiseStaticRoutes { get; set; }
        /// <summary>
        /// TIER1 logical router id on which to enable this configuration
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id")]
        public string? LogicalRouterId { get; set; }
        /// <summary>
        /// Flag to advertise all routes of dns forwarder listener ips and source ips
        /// </summary>
        [JsonProperty(PropertyName = "advertise_dns_forwarder")]
        public bool? AdvertiseDnsForwarder { get; set; }
        /// <summary>
        /// Flag to advertise all routes of nat
        /// </summary>
        [JsonProperty(PropertyName = "advertise_nat_routes")]
        public bool? AdvertiseNatRoutes { get; set; }
        /// <summary>
        /// Flag to advertise all IPSec VPN local endpoint ips to linked TIER0 logical router
        /// </summary>
        [JsonProperty(PropertyName = "advertise_ipsec_local_ip")]
        public bool? AdvertiseIpsecLocalIp { get; set; }
        /// <summary>
        /// Flag to enable this configuration
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Flag to advertise all lb SNAT ips
        /// </summary>
        [JsonProperty(PropertyName = "advertise_lb_snat_ip")]
        public bool? AdvertiseLbSnatIp { get; set; }
    }
}
