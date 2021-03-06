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
    public class NSXTDhcpv6HeaderType 
    {
        /// <summary>
        /// This is used to specify the DHCP v6 message. To request the assignment of one or more IPv6 addresses, a client first
        /// locates a DHCP server and then requests the assignment of addresses and other configuration information from the server.
        /// The client sends a Solicit message to the All_DHCP_Relay_Agents_and_Servers address to find available DHCP servers. Any
        /// server that can meet the client's requirements responds with an Advertise message. The client then chooses one of the
        /// servers and sends a Request message to the server asking for confirmed assignment of addresses and other configuration
        /// information. The server responds with a Reply message that contains the confirmed addresses and configuration. SOLICIT -
        /// A client sends a Solicit message to locate servers. ADVERTISE - A server sends and Advertise message to indicate that it
        /// is available. REQUEST - A client sends a Request message to request configuration parameters. REPLY - A server sends a
        /// Reply message containing assigned addresses and configuration parameters.
        /// </summary>
        [JsonProperty(PropertyName = "msg_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDhcpv6HeaderMsgTypeEnumType? MsgType { get; set; }
    }
}
