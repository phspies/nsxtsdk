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
    public class NSXTLBFastUdpProfileType : NSXTLBAppProfileType
    {
        /// <summary>
        /// Though UDP is a connectionless protocol, for the purposes of load
        /// balancing, all UDP packets with the same flow signature (source and
        /// destination IP/ports and IP protocol) received within the idle timeout
        /// period are considered to belong to the same connection and are sent to
        /// the same backend server. If no packets are received for idle timeout
        /// period, the connection (association between flow signature and the
        /// selected server) is cleaned up.
        /// </summary>
        [JsonProperty(PropertyName = "idle_timeout")]
        [NSXTProperty(IsRequired: false, Description: @"Though UDP is a connectionless protocol, for the purposes of loadbalancing, all UDP packets with the same flow signature (source anddestination IP/ports and IP protocol) received within the idle timeoutperiod are considered to belong to the same connection and are sent tothe same backend server. If no packets are received for idle timeoutperiod, the connection (association between flow signature and theselected server) is cleaned up.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(2147483647)]
        [NSXTDefaultProperty(Default: "")]
        public long? IdleTimeout { get; set; }
        /// <summary>
        /// If flow mirroring is enabled, all the flows to the bounded virtual
        /// server are mirrored to the standby node.
        /// </summary>
        [JsonProperty(PropertyName = "flow_mirroring_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"If flow mirroring is enabled, all the flows to the bounded virtualserver are mirrored to the standby node.")]
        public bool? FlowMirroringEnabled { get; set; }
    }
}