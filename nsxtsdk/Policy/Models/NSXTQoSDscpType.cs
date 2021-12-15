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
    /// Dscp value is ignored in case of 'TRUSTED' DscpTrustMode.
    /// </summary>
    [NSXTProperty(Description: @"Dscp value is ignored in case of &apos;TRUSTED&apos; DscpTrustMode.")]
    public class NSXTQoSDscpType 
    {
        /// <summary>
        /// Internal Forwarding Priority
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        [NSXTProperty(IsRequired: false, Description: @"Internal Forwarding Priority")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(63)]
        [NSXTDefaultProperty(Default: "")]
        public long? Priority { get; set; }
        /// <summary>
        /// When you select the Trusted mode the inner header DSCP value is applied
        /// to the outer IP header for IP/IPv6 traffic. For non IP/IPv6 traffic,
        /// the outer IP header takes the default value.Untrusted mode is supported
        /// on overlay-based and VLAN-based logical port.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        [NSXTProperty(IsRequired: false, Description: @"When you select the Trusted mode the inner header DSCP value is appliedto the outer IP header for IP/IPv6 traffic. For non IP/IPv6 traffic,the outer IP header takes the default value.Untrusted mode is supportedon overlay-based and VLAN-based logical port.")]
        public NSXTQoSdscpModeEnumType? Mode { get; set; }
    }
}
