using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// This is deprecated. Please use CommonAgentPrivateIpRangeInfo instead.
        /// An IP prefix to mark the private network that NSX-Intelligence
        /// network flow is collected from.
    /// </summary>
    [NSXTProperty(Description: @"This is deprecated. Please use CommonAgentPrivateIpRangeInfo instead.An IP prefix to mark the private network that NSX-Intelligencenetwork flow is collected from.")]
    public class NSXTIntelligenceFlowPrivateIpPrefixInfoType 
    {
        /// <summary>
        /// The type of IP address.
        /// </summary>
        [JsonProperty(PropertyName = "address_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIntelligenceFlowPrivateIpPrefixInfoAddressTypeEnumType AddressType { get; set; }
        /// <summary>
        /// The length of IP address prefix that marks the range of private network.
        /// </summary>
        [JsonProperty(PropertyName = "prefix_length", Required = Required.AllowNull)]
        public long PrefixLength { get; set; }
        /// <summary>
        /// The prefix of IP address that marks the range of private network.
        /// </summary>
        [JsonProperty(PropertyName = "address", Required = Required.AllowNull)]
        public string Address { get; set; }
    }
}
