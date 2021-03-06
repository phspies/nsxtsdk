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
    /// Neighbor discovery protocol header
    /// </summary>
    [NSXTProperty(Description: @"Neighbor discovery protocol header")]
    public class NSXTNdpHeaderType 
    {
        /// <summary>
        /// The IP address of the destination of the solicitation. It MUST NOT be a multicast address.
        /// </summary>
        [JsonProperty(PropertyName = "dst_ip")]
        public string? DstIp { get; set; }
        /// <summary>
        /// This field specifies the type of the Neighbor discover message being sent. NEIGHBOR_SOLICITATION - Neighbor Solicitation
        /// message to discover the link-layer address of an on-link IPv6 node or to confirm a previously determined link-layer
        /// address. NEIGHBOR_ADVERTISEMENT - Neighbor Advertisement message in response to a Neighbor Solicitation message.
        /// </summary>
        [JsonProperty(PropertyName = "msg_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNdpHeaderMsgTypeEnumType? MsgType { get; set; }
    }
}
