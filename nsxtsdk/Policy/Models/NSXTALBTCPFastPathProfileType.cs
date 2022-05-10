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
    /// Advanced load balancer TCPFastPathProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer TCPFastPathProfile object")]
    public class NSXTALBTCPFastPathProfileType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dsr_profile")]
        public NSXTALBDsrProfileType DsrProfile { get; set; }
        /// <summary>
        /// When enabled, Avi will complete the 3-way handshake with
        /// the client before forwarding any packets to the server.
        /// This will protect the server from SYN flood and half open
        /// SYN connections.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enable_syn_protection")]
        public bool? EnableSynProtection { get; set; }
        /// <summary>
        /// The amount of time (in sec) for which a connection needs to
        /// be idle before it is eligible to be deleted.
        /// Allowed values are 5-14400.
        /// Special values are 0 - 'infinite'.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 300.
        /// </summary>
        [JsonProperty(PropertyName = "session_idle_timeout")]
        public long? SessionIdleTimeout { get; set; }
    }
}
