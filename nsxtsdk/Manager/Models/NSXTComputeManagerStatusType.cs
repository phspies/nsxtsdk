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
    /// Runtime status information of the compute manager
    /// </summary>
    [NSXTProperty(Description: @"Runtime status information of the compute manager")]
    public class NSXTComputeManagerStatusType 
    {
        public NSXTComputeManagerStatusType()
        {
        }
        /// <summary>
        /// Version of the compute manager
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        [NSXTProperty(IsRequired: false, Description: @"Version of the compute manager")]
        public string? Version { get; set; }
        /// <summary>
        /// Status of connection with the compute manager
        /// </summary>
        [JsonProperty(PropertyName = "connection_status")]
        [NSXTProperty(IsRequired: false, Description: @"Status of connection with the compute manager")]
        public NSXTComputeManagerStatusConnectionStatusEnumType? ConnectionStatus { get; set; }
        /// <summary>
        /// Errors when connecting with compute manager
        /// </summary>
        [JsonProperty(PropertyName = "connection_errors")]
        [NSXTProperty(IsRequired: false, Description: @"Errors when connecting with compute manager")]
        public IList<NSXTErrorInfoType> ConnectionErrors { get; set; }
        /// <summary>
        /// If Compute manager is trusted as authorization server, then
        /// this Id will be Id of corresponding oidc end point.
        /// </summary>
        [JsonProperty(PropertyName = "oidc_end_point_id")]
        [NSXTProperty(IsRequired: false, Description: @"If Compute manager is trusted as authorization server, thenthis Id will be Id of corresponding oidc end point.")]
        public string? OidcEndPointId { get; set; }
        /// <summary>
        /// Timestamp of the last successful update of Inventory, in epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "last_sync_time")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp of the last successful update of Inventory, in epoch milliseconds.")]
        public long? LastSyncTime { get; set; }
        /// <summary>
        /// Details about connection status
        /// </summary>
        [JsonProperty(PropertyName = "connection_status_details")]
        [NSXTProperty(IsRequired: false, Description: @"Details about connection status")]
        public string? ConnectionStatusDetails { get; set; }
        /// <summary>
        /// Errors when registering with compute manager
        /// </summary>
        [JsonProperty(PropertyName = "registration_errors")]
        [NSXTProperty(IsRequired: false, Description: @"Errors when registering with compute manager")]
        public IList<NSXTErrorInfoType> RegistrationErrors { get; set; }
        /// <summary>
        /// Registration status of compute manager
        /// </summary>
        [JsonProperty(PropertyName = "registration_status")]
        [NSXTProperty(IsRequired: false, Description: @"Registration status of compute manager")]
        public NSXTComputeManagerStatusRegistrationStatusEnumType? RegistrationStatus { get; set; }
    }
}
