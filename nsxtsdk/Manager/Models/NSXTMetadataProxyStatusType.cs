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
    public class NSXTMetadataProxyStatusType 
    {
        /// <summary>
        /// UP means the metadata proxy is working fine on both transport-nodes(if have);
        /// DOWN means the metadata proxy is is down on both transport-nodes(if have),
        /// hence the metadata proxy will not repsonse any metadata request;
        /// Error means error happens on transport-node(s) or no status is reported from
        /// transport-node(s). The metadata proxy may be working (or not working);
        /// NO_BACK means metadata proxy is working in one of the transport node while
        /// not in the other transport-node (if have). Hence if the metadata proxy in
        /// the working transport-node goes down, the metadata proxy will go down.
        /// </summary>
        [JsonProperty(PropertyName = "proxy_status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMetadataProxyStatusProxyStatusEnumType ProxyStatus { get; set; }
        /// <summary>
        /// Error message, if available
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Order of the transport nodes is insensitive because Metadata Proxy
        /// is running in Active-Active mode among target transport nodes.
        /// </summary>
        [JsonProperty(PropertyName = "transport_nodes", Required = Required.AllowNull)]
        public IList<string> TransportNodes { get; set; }
    }
}
