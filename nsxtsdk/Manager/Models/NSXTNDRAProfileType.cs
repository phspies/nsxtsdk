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
    public class NSXTNDRAProfileType : NSXTManagedResourceType
    {
        /// <summary>
        /// RA Mode
        /// </summary>
        [JsonProperty(PropertyName = "ra_mode", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNdraprofileRaModeEnumType RaMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ra_config", Required = Required.AllowNull)]
        public NSXTRAConfigType RaConfig { get; set; }
        /// <summary>
        /// The time, in milliseconds, between retransmitted neighbour
        /// solicitation messages.
        /// </summary>
        [JsonProperty(PropertyName = "retransmit_interval")]
        public long? RetransmitInterval { get; set; }
        /// <summary>
        /// Route advertised in NDRAProfile.
        /// </summary>
        [JsonProperty(PropertyName = "ndra_advertised_route")]
        public IList<NSXTNDRAAdvertisedRouteType> NdraAdvertisedRoute { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dns_config")]
        public NSXTRaDNSConfigType DnsConfig { get; set; }
        /// <summary>
        /// Neighbour reachable time duration in milliseconds.
        /// A value of 0 means unspecified.
        /// </summary>
        [JsonProperty(PropertyName = "reachable_timer")]
        public long? ReachableTimer { get; set; }
    }
}
