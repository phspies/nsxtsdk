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
    /// List of MAC Addresses.
    /// </summary>
    [NSXTProperty(Description: @"List of MAC Addresses.")]
    public class NSXTMACAddressListType 
    {
        /// <summary>
        /// The array contains MAC addresses.
        /// </summary>
        [JsonProperty(PropertyName = "mac_addresses", Required = Required.AllowNull)]
        public IList<string> MacAddresses { get; set; }
    }
}
