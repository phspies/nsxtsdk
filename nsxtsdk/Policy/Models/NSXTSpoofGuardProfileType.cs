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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSpoofGuardProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// If true, enable the SpoofGuard, which only allows VM sending traffic
        /// with the IPs in the whitelist. This field is deprecated because it
        /// has offensive terminology. Please use address_binding_allowlist.
        /// This value cannot conflict with allow list.
        /// </summary>
        [JsonProperty(PropertyName = "address_binding_whitelist", Required = Required.AllowNull)]
        public bool AddressBindingWhitelist { get; set; }
        /// <summary>
        /// If true, enable the SpoofGuard, which only allows VM sending traffic
        /// with the IPs in the whitelist. This value cannot conflict with whitelist.
        /// </summary>
        [JsonProperty(PropertyName = "address_binding_allowlist", Required = Required.AllowNull)]
        public bool AddressBindingAllowlist { get; set; }
    }
}
