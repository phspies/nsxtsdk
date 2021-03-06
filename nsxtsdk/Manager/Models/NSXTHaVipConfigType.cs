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
    public class NSXTHaVipConfigType 
    {
        /// <summary>
        /// Array of IP address subnets which will be used as floating IP addresses. | Note - this configuration is applicable only
        /// for Active-Standby LogicalRouter. | For Active-Active LogicalRouter this configuration will be rejected.
        /// </summary>
        [JsonProperty(PropertyName = "ha_vip_subnets", Required = Required.AllowNull)]
        public IList<NSXTVIPSubnetType> HaVipSubnets { get; set; }
        /// <summary>
        /// Identifiers of logical router uplink ports which are to be paired to provide | redundancy. Floating IP will be owned by
        /// one of these uplink ports (depending upon | which node is Active).
        /// </summary>
        [JsonProperty(PropertyName = "redundant_uplink_port_ids", Required = Required.AllowNull)]
        public IList<string> RedundantUplinkPortIds { get; set; }
        /// <summary>
        /// Flag to enable this ha vip config.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
    }
}
