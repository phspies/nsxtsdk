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
    public class NSXTTransportNodeStatusType 
    {
        /// <summary>
        /// Roll-up status of pNIC, management connection, control connection, tunnel status, agent status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"Roll-up status of pNIC, management connection, control connection, tunnel status, agent status")]
        public NSXTTransportNodeStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Threat status
        /// </summary>
        [JsonProperty(PropertyName = "threat_status")]
        [NSXTProperty(IsRequired: false, Description: @"Threat status")]
        public NSXTThreatStatusType ThreatStatus { get; set; }
        /// <summary>
        /// NSX agents status
        /// </summary>
        [JsonProperty(PropertyName = "agent_status")]
        [NSXTProperty(IsRequired: false, Description: @"NSX agents status")]
        public NSXTAgentStatusCountType AgentStatus { get; set; }
        /// <summary>
        /// Transport node uuid
        /// </summary>
        [JsonProperty(PropertyName = "node_uuid")]
        [NSXTProperty(IsRequired: false, Description: @"Transport node uuid")]
        public string? NodeUuid { get; set; }
        /// <summary>
        /// Tunnel Status
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_status")]
        [NSXTProperty(IsRequired: false, Description: @"Tunnel Status")]
        public NSXTTunnelStatusCountType TunnelStatus { get; set; }
        /// <summary>
        /// Management connection status
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_connection_status")]
        [NSXTProperty(IsRequired: false, Description: @"Management connection status")]
        public NSXTTransportNodeStatusMgmtConnectionStatusEnumType? MgmtConnectionStatus { get; set; }
        /// <summary>
        /// Control connection status
        /// </summary>
        [JsonProperty(PropertyName = "control_connection_status")]
        [NSXTProperty(IsRequired: false, Description: @"Control connection status")]
        public NSXTStatusCountType ControlConnectionStatus { get; set; }
        /// <summary>
        /// pNIC status
        /// </summary>
        [JsonProperty(PropertyName = "pnic_status")]
        [NSXTProperty(IsRequired: false, Description: @"pNIC status")]
        public NSXTStatusCountType PnicStatus { get; set; }
        /// <summary>
        /// Node status
        /// </summary>
        [JsonProperty(PropertyName = "node_status")]
        [NSXTProperty(IsRequired: false, Description: @"Node status")]
        public NSXTNodeStatusType NodeStatus { get; set; }
        /// <summary>
        /// Transport node display name
        /// </summary>
        [JsonProperty(PropertyName = "node_display_name")]
        [NSXTProperty(IsRequired: false, Description: @"Transport node display name")]
        public string? NodeDisplayName { get; set; }
    }
}