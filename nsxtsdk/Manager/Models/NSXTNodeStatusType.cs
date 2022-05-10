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
    /// Runtime status information of the fabric node.
    /// </summary>
    [NSXTProperty(Description: @"Runtime status information of the fabric node.")]
    public class NSXTNodeStatusType 
    {
        /// <summary>
        /// Indicates the fabric node's MP<->MPA channel connectivity status, UP, DOWN, UNKNOWN.
        /// </summary>
        [JsonProperty(PropertyName = "mpa_connectivity_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeStatusMpaConnectivityStatusEnumType? MpaConnectivityStatus { get; set; }
        /// <summary>
        /// Details, if any, about the current LCP<->CCP channel connectivity status of the fabric node.
        /// </summary>
        [JsonProperty(PropertyName = "lcp_connectivity_status_details")]
        public IList<NSXTControlConnStatusType> LcpConnectivityStatusDetails { get; set; }
        /// <summary>
        /// Details, if any, about the current MP<->MPA channel connectivity status of the fabric node.
        /// </summary>
        [JsonProperty(PropertyName = "mpa_connectivity_status_details")]
        public string? MpaConnectivityStatusDetails { get; set; }
        /// <summary>
        /// HostNode external id
        /// </summary>
        [JsonProperty(PropertyName = "external_id")]
        public string? ExternalId { get; set; }
        /// <summary>
        /// Software version of the fabric node.
        /// </summary>
        [JsonProperty(PropertyName = "software_version")]
        public string? SoftwareVersion { get; set; }
        /// <summary>
        /// Indicates the fabric node's status of maintenance mode, OFF, ENTERING, ON, EXITING.
        /// </summary>
        [JsonProperty(PropertyName = "maintenance_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeStatusMaintenanceModeEnumType? MaintenanceMode { get; set; }
        /// <summary>
        /// Is true if inventory sync is paused else false
        /// </summary>
        [JsonProperty(PropertyName = "inventory_sync_paused")]
        public bool? InventorySyncPaused { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "system_status")]
        public NSXTNodeStatusPropertiesType SystemStatus { get; set; }
        /// <summary>
        /// Inventory sync auto re-enable target time, in epoch milis
        /// </summary>
        [JsonProperty(PropertyName = "inventory_sync_reenable_time")]
        public long? InventorySyncReenableTime { get; set; }
        /// <summary>
        /// Indicates the fabric node's LCP<->CCP channel connectivity status, UP, DOWN, DEGRADED, UNKNOWN.
        /// </summary>
        [JsonProperty(PropertyName = "lcp_connectivity_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeStatusLcpConnectivityStatusEnumType? LcpConnectivityStatus { get; set; }
        /// <summary>
        /// Timestamp of the last heartbeat status change, in epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "last_heartbeat_timestamp")]
        public long? LastHeartbeatTimestamp { get; set; }
        /// <summary>
        /// Timestamp of the last successful update of Inventory, in epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "last_sync_time")]
        public long? LastSyncTime { get; set; }
        /// <summary>
        /// This enum specifies the current nsx install state for host node or
        /// current deployment and ready state for edge node.
        /// The ready status 'NODE_READY' indicates whether edge node is
        /// ready to become a transport node.
        /// The status 'EDGE_CONFIG_ERROR' indicates that edge hardware or underlying
        /// host is not supported. After all fabric level operations are done for an
        /// edge node, this value indicates transport node related configuration
        /// issues and state as relevant.
        /// </summary>
        [JsonProperty(PropertyName = "host_node_deployment_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeStatusHostNodeDeploymentStatusEnumType? HostNodeDeploymentStatus { get; set; }
    }
}
