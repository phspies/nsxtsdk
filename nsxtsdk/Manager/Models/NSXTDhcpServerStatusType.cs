// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: false, Description: @"Error message, if available")]
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
        [NSXTProperty(IsRequired: true, Description: @"UP means the dhcp service is working fine on both active transport-nodeand stand-by transport-node (if have), hence fail-over can work at thistime if there is failure happens on one of the transport-node;DOWN means the dhcp service is down on both active transport-node andstand-by node (if have), hence the dhcp-service will not repsonse anydhcp request;Error means error happens on transport-node(s) or no status is reported fromtransport-node(s). The dhcp service may be working (or not working);NO_STANDBY means dhcp service is working in one of the transport node whilenot in the other transport-node (if have). Hence if the dhcp service inthe working transport-node is down, fail-over will not happen and thedhcp service will go down.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTDhcpServerStatusServiceStatusEnumType ServiceStatus { get; set; }
        /// <summary>
        /// uuid of stand_by transport node. null if non-HA mode
        /// </summary>
        [JsonProperty(PropertyName = "stand_by_node")]
        [NSXTProperty(IsRequired: false, Description: @"uuid of stand_by transport node. null if non-HA mode")]
        public string? StandByNode { get; set; }
        /// <summary>
        /// uuid of active transport node
        /// </summary>
        [JsonProperty(PropertyName = "active_node", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"uuid of active transport node")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ActiveNode { get; set; }
    }
}
