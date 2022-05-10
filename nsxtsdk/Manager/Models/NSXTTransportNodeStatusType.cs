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
    public class NSXTTransportNodeStatusType 
    {
        /// <summary>
        /// Roll-up status of pNIC, management connection, control connection, tunnel status, agent status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTransportNodeStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "threat_status")]
        public NSXTThreatStatusType ThreatStatus { get; set; }
        /// <summary>
        /// Transport node uuid
        /// </summary>
        [JsonProperty(PropertyName = "node_uuid")]
        public string? NodeUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "control_connection_status")]
        public NSXTStatusCountType ControlConnectionStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "pnic_status")]
        public NSXTStatusCountType PnicStatus { get; set; }
        /// <summary>
        /// Transport node path
        /// </summary>
        [JsonProperty(PropertyName = "node_path")]
        public string? NodePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "agent_status")]
        public NSXTAgentStatusCountType AgentStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "node_status")]
        public NSXTNodeStatusType NodeStatus { get; set; }
        /// <summary>
        /// Management connection status
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_connection_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTransportNodeStatusMgmtConnectionStatusEnumType? MgmtConnectionStatus { get; set; }
        /// <summary>
        /// Transport node display name
        /// </summary>
        [JsonProperty(PropertyName = "node_display_name")]
        public string? NodeDisplayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_status")]
        public NSXTTunnelStatusCountType TunnelStatus { get; set; }
    }
}
