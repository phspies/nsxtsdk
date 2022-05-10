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
    /// Advanced load balancer UDPFastPathProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer UDPFastPathProfile object")]
    public class NSXTALBUDPFastPathProfileType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dsr_profile")]
        public NSXTALBDsrProfileType DsrProfile { get; set; }
        /// <summary>
        /// When enabled, every UDP packet is considered a new
        /// transaction and may be load balanced to a different server.
        /// When disabled, packets from the same client source IP and
        /// port are sent to the same server.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "per_pkt_loadbalance")]
        public bool? PerPktLoadbalance { get; set; }
        /// <summary>
        /// When disabled, Source NAT will not be performed for all
        /// client UDP packets.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "snat")]
        public bool? Snat { get; set; }
        /// <summary>
        /// The amount of time (in sec) for which a flow needs to be
        /// idle before it is deleted.
        /// Allowed values are 2-3600.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 10.
        /// </summary>
        [JsonProperty(PropertyName = "session_idle_timeout")]
        public long? SessionIdleTimeout { get; set; }
    }
}
