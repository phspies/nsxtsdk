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
    /// Used to specify the display name and value of the IPv4Address.
    /// </summary>
    [NSXTProperty(Description: @"Used to specify the display name and value of the IPv4Address.")]
    public class NSXTPolicyIPAddressInfoType 
    {
        /// <summary>
        /// Next hop used in auto-plumbing of static route. If a value is not
        /// provided, static route will not be auto-plumbed.
        /// </summary>
        [JsonProperty(PropertyName = "next_hop")]
        public string? NextHop { get; set; }
        /// <summary>
        /// Value of the IPv4Address.
        /// </summary>
        [JsonProperty(PropertyName = "address_value", Required = Required.AllowNull)]
        public string AddressValue { get; set; }
        /// <summary>
        /// Display name used to help identify the IPv4Address.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
    }
}
