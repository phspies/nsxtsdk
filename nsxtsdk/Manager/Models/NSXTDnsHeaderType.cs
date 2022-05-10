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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDnsHeaderType 
    {
        /// <summary>
        /// This is used to specify the type of the address. V4 - The address provided is an IPv4 domain name/IP address, the Type
        /// in query or response will be A V6 - The address provided is an IPv6 domain name/IP address, the Type in query or
        /// response will be AAAA
        /// </summary>
        [JsonProperty(PropertyName = "address_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDnsHeaderAddressTypeEnumType? AddressType { get; set; }
        /// <summary>
        /// Specifies the message type whether it is a query or a response.
        /// </summary>
        [JsonProperty(PropertyName = "message_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDnsHeaderMessageTypeEnumType? MessageType { get; set; }
        /// <summary>
        /// This is used to define what is being asked or responded.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string? Address { get; set; }
    }
}
