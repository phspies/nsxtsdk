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
    /// Intersite gateway configuration.
    /// </summary>
    [NSXTProperty(Description: @"Intersite gateway configuration.")]
    public class NSXTIntersiteGatewayConfigType 
    {
        /// <summary>
        /// IPv4 subnet for inter-site transit segment connecting service routers
        /// across sites for stretched gateway. For IPv6 link local subnet is
        /// auto configured.
        /// </summary>
        [JsonProperty(PropertyName = "intersite_transit_subnet")]
        public string? IntersiteTransitSubnet { get; set; }
        /// <summary>
        /// Primary egress site for gateway. T0/T1 gateway in Active/Standby mode
        /// supports stateful services on primary site. In this mode primary site
        /// must be set if gateway is stretched to more than one site. For T0 gateway
        /// in Active/Active primary site is optional field. If set then secondary site
        /// prefers routes learned from primary over locally learned routes. This field
        /// is not applicable for T1 gateway with no services.
        /// </summary>
        [JsonProperty(PropertyName = "primary_site_path")]
        public string? PrimarySitePath { get; set; }
        /// <summary>
        /// Epoch(in seconds) is auto updated based on system current timestamp
        /// when primary locale service is updated. It is used for resolving conflict
        /// during site failover. If system clock not in sync then User can optionally
        /// override this. New value must be higher than the current value.
        /// </summary>
        [JsonProperty(PropertyName = "last_admin_active_epoch")]
        public long? LastAdminActiveEpoch { get; set; }
        /// <summary>
        /// Fallback site to be used as new primary site on current primary site
        /// failure. Disaster recovery must be initiated via API/UI. Fallback site
        /// configuration is supported only for T0 gateway. T1 gateway will follow
        /// T0 gateway's primary site during disaster recovery.
        /// </summary>
        [JsonProperty(PropertyName = "fallback_sites")]
        public IList<string> FallbackSites { get; set; }
    }
}
