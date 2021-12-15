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
    /// Advanced load balancer HealthMonitorSIP object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HealthMonitorSIP object")]
    public class NSXTALBHealthMonitorSIPType 
    {
        /// <summary>
        /// Specify the transport protocol TCP or UDP, to be used for
        /// SIP health monitor.
        /// The default transport is UDP.
        /// Enum options - SIP_UDP_PROTO, SIP_TCP_PROTO.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as SIP_UDP_PROTO.
        /// </summary>
        [JsonProperty(PropertyName = "sip_monitor_transport")]
        [NSXTProperty(IsRequired: false, Description: @"Specify the transport protocol TCP or UDP, to be used forSIP health monitor.The default transport is UDP.Enum options - SIP_UDP_PROTO, SIP_TCP_PROTO.Default value when not specified in API or module isinterpreted by ALB Controller as SIP_UDP_PROTO.")]
        [NSXTDefaultProperty(Default: "SIP_UDP_PROTO")]
        public NSXTAlbhealthMonitorSIPSipMonitorTransportEnumType? SipMonitorTransport { get; set; }
        /// <summary>
        /// Specify the SIP request to be sent to the server.
        /// By default, SIP OPTIONS request will be sent.
        /// Enum options - SIP_OPTIONS.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as SIP_OPTIONS.
        /// </summary>
        [JsonProperty(PropertyName = "sip_request_code")]
        [NSXTProperty(IsRequired: false, Description: @"Specify the SIP request to be sent to the server.By default, SIP OPTIONS request will be sent.Enum options - SIP_OPTIONS.Default value when not specified in API or module isinterpreted by ALB Controller as SIP_OPTIONS.")]
        [NSXTDefaultProperty(Default: "SIP_OPTIONS")]
        public NSXTAlbhealthMonitorSIPSipRequestCodeEnumType? SipRequestCode { get; set; }
        /// <summary>
        /// Match for a keyword in the first 2KB of the server header
        /// and body response.
        /// By default, it matches for SIP/2.0.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as SIP/2.0.
        /// </summary>
        [JsonProperty(PropertyName = "sip_response")]
        [NSXTProperty(IsRequired: false, Description: @"Match for a keyword in the first 2KB of the server headerand body response.By default, it matches for SIP/2.0.Default value when not specified in API or module isinterpreted by ALB Controller as SIP/2.0.")]
        [NSXTDefaultProperty(Default: "SIP/2.0")]
        public string? SipResponse { get; set; }
    }
}