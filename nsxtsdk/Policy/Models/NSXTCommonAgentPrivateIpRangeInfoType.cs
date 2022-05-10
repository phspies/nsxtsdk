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
    /// An IP prefix to mark the private network that NSX Application Platform Common Agent
        /// network flow is collected from.
    /// </summary>
    [NSXTProperty(Description: @"An IP prefix to mark the private network that NSX Application Platform Common Agentnetwork flow is collected from.")]
    public class NSXTCommonAgentPrivateIpRangeInfoType 
    {
        /// <summary>
        /// The type of IP address.
        /// </summary>
        [JsonProperty(PropertyName = "address_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTCommonAgentPrivateIpRangeInfoAddressTypeEnumType AddressType { get; set; }
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
