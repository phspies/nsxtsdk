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
    /// Runtime status information of the compute manager
    /// </summary>
    [NSXTProperty(Description: @"Runtime status information of the compute manager")]
    public class NSXTComputeManagerStatusType 
    {
        /// <summary>
        /// Version of the compute manager
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
        /// <summary>
        /// Status of connection with the compute manager
        /// </summary>
        [JsonProperty(PropertyName = "connection_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTComputeManagerStatusConnectionStatusEnumType? ConnectionStatus { get; set; }
        /// <summary>
        /// Errors when connecting with compute manager
        /// </summary>
        [JsonProperty(PropertyName = "connection_errors")]
        public IList<NSXTErrorInfoType> ConnectionErrors { get; set; }
        /// <summary>
        /// If Compute manager is trusted as authorization server, then
        /// this Id will be Id of corresponding oidc end point.
        /// </summary>
        [JsonProperty(PropertyName = "oidc_end_point_id")]
        public string? OidcEndPointId { get; set; }
        /// <summary>
        /// Timestamp of the last successful update of Inventory, in epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "last_sync_time")]
        public long? LastSyncTime { get; set; }
        /// <summary>
        /// Details about connection status
        /// </summary>
        [JsonProperty(PropertyName = "connection_status_details")]
        public string? ConnectionStatusDetails { get; set; }
        /// <summary>
        /// Errors when registering with compute manager
        /// </summary>
        [JsonProperty(PropertyName = "registration_errors")]
        public IList<NSXTErrorInfoType> RegistrationErrors { get; set; }
        /// <summary>
        /// Registration status of compute manager
        /// </summary>
        [JsonProperty(PropertyName = "registration_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTComputeManagerStatusRegistrationStatusEnumType? RegistrationStatus { get; set; }
    }
}
