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
    public class NSXTDhcpServerStatusType 
    {
        /// <summary>
        /// Error message, if available
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// UP means the dhcp service is working fine on both active transport-node
        /// and stand-by transport-node (if have), hence fail-over can work at this
        /// time if there is failure happens on one of the transport-node;
        /// DOWN means the dhcp service is down on both active transport-node and
        /// stand-by node (if have), hence the dhcp-service will not repsonse any
        /// dhcp request;
        /// Error means error happens on transport-node(s) or no status is reported from
        /// transport-node(s). The dhcp service may be working (or not working);
        /// NO_STANDBY means dhcp service is working in one of the transport node while
        /// not in the other transport-node (if have). Hence if the dhcp service in
        /// the working transport-node is down, fail-over will not happen and the
        /// dhcp service will go down.
        /// </summary>
        [JsonProperty(PropertyName = "service_status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDhcpServerStatusServiceStatusEnumType ServiceStatus { get; set; }
        /// <summary>
        /// uuid of stand_by transport node. null if non-HA mode
        /// </summary>
        [JsonProperty(PropertyName = "stand_by_node")]
        public string? StandByNode { get; set; }
        /// <summary>
        /// uuid of active transport node
        /// </summary>
        [JsonProperty(PropertyName = "active_node", Required = Required.AllowNull)]
        public string ActiveNode { get; set; }
    }
}
