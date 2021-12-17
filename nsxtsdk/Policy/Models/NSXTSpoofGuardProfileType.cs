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
    public class NSXTSpoofGuardProfileType : NSXTPolicyConfigResourceType
    {
        public NSXTSpoofGuardProfileType()
        {
        }
        /// <summary>
        /// If true, enable the SpoofGuard, which only allows VM sending traffic
        /// with the IPs in the whitelist. This field is deprecated because it
        /// has offensive terminology. Please use address_binding_allowlist.
        /// This value cannot conflict with allow list.
        /// </summary>
        [JsonProperty(PropertyName = "address_binding_whitelist", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"If true, enable the SpoofGuard, which only allows VM sending trafficwith the IPs in the whitelist. This field is deprecated because ithas offensive terminology. Please use address_binding_allowlist.This value cannot conflict with allow list.")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool AddressBindingWhitelist { get; set; }
        /// <summary>
        /// If true, enable the SpoofGuard, which only allows VM sending traffic
        /// with the IPs in the whitelist. This value cannot conflict with whitelist.
        /// </summary>
        [JsonProperty(PropertyName = "address_binding_allowlist", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"If true, enable the SpoofGuard, which only allows VM sending trafficwith the IPs in the whitelist. This value cannot conflict with whitelist.")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool AddressBindingAllowlist { get; set; }
    }
}
