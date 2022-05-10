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
    /// Dscp value is ignored in case of 'TRUSTED' DscpTrustMode.
    /// </summary>
    [NSXTProperty(Description: @"Dscp value is ignored in case of &apos;TRUSTED&apos; DscpTrustMode.")]
    public class NSXTQoSDscpType 
    {
        /// <summary>
        /// Internal Forwarding Priority
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }
        /// <summary>
        /// When you select the Trusted mode the inner header DSCP value is applied
        /// to the outer IP header for IP/IPv6 traffic. For non IP/IPv6 traffic,
        /// the outer IP header takes the default value.Untrusted mode is supported
        /// on overlay-based and VLAN-based logical port.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTQoSdscpModeEnumType? Mode { get; set; }
    }
}
