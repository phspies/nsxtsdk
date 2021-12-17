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
    public class NSXTIpv6NdraProfileType : NSXTPolicyConfigResourceType
    {
        public NSXTIpv6NdraProfileType()
        {
            RaMode = test
            RetransmitInterval = test
            ReachableTimer = test
        }
        /// <summary>
        /// RA Mode
        /// </summary>
        [JsonProperty(PropertyName = "ra_mode", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"RA Mode")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTIpv6NdraProfileRaModeEnumType RaMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ra_config", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTRAConfigType RaConfig { get; set; }
        /// <summary>
        /// The time, in milliseconds, between retransmitted neighbour
        /// solicitation messages. A value of 0 means unspecified.
        /// </summary>
        [JsonProperty(PropertyName = "retransmit_interval")]
        [NSXTProperty(IsRequired: false, Description: @"The time, in milliseconds, between retransmitted neighboursolicitation messages. A value of 0 means unspecified.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(4294967295)]
        public long? RetransmitInterval { get; set; }
        /// <summary>
        /// Route advertised in NDRAProfile.
        /// </summary>
        [JsonProperty(PropertyName = "ndra_advertised_route")]
        [NSXTProperty(IsRequired: false, Description: @"Route advertised in NDRAProfile.")]
        public IList<NSXTNDRAAdvertisedRouteType> NdraAdvertisedRoute { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dns_config")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTRaDNSConfigType DnsConfig { get; set; }
        /// <summary>
        /// Neighbour reachable time duration in milliseconds.
        /// A value of 0 means unspecified.
        /// </summary>
        [JsonProperty(PropertyName = "reachable_timer")]
        [NSXTProperty(IsRequired: false, Description: @"Neighbour reachable time duration in milliseconds.A value of 0 means unspecified.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(3600000)]
        public long? ReachableTimer { get; set; }
    }
}
