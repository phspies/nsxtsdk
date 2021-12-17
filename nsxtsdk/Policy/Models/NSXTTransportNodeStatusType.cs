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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTransportNodeStatusType 
    {
        public NSXTTransportNodeStatusType()
        {
        }
        /// <summary>
        /// Roll-up status of pNIC, management connection, control connection, tunnel status, agent status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"Roll-up status of pNIC, management connection, control connection, tunnel status, agent status")]
        public NSXTTransportNodeStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "threat_status")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTThreatStatusType ThreatStatus { get; set; }
        /// <summary>
        /// Transport node uuid
        /// </summary>
        [JsonProperty(PropertyName = "node_uuid")]
        [NSXTProperty(IsRequired: false, Description: @"Transport node uuid")]
        public string? NodeUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "control_connection_status")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTStatusCountType ControlConnectionStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "pnic_status")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTStatusCountType PnicStatus { get; set; }
        /// <summary>
        /// Transport node path
        /// </summary>
        [JsonProperty(PropertyName = "node_path")]
        [NSXTProperty(IsRequired: false, Description: @"Transport node path")]
        public string? NodePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "agent_status")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTAgentStatusCountType AgentStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "node_status")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTNodeStatusType NodeStatus { get; set; }
        /// <summary>
        /// Management connection status
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_connection_status")]
        [NSXTProperty(IsRequired: false, Description: @"Management connection status")]
        public NSXTTransportNodeStatusMgmtConnectionStatusEnumType? MgmtConnectionStatus { get; set; }
        /// <summary>
        /// Transport node display name
        /// </summary>
        [JsonProperty(PropertyName = "node_display_name")]
        [NSXTProperty(IsRequired: false, Description: @"Transport node display name")]
        public string? NodeDisplayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_status")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTTunnelStatusCountType TunnelStatus { get; set; }
    }
}