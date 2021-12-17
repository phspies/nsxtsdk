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
    public class NSXTFederationStatusType 
    {
        public NSXTFederationStatusType()
        {
        }
        /// <summary>
        /// Site connection status
        /// </summary>
        [JsonProperty(PropertyName = "remote_connections")]
        [NSXTProperty(IsRequired: false, Description: @"Site connection status")]
        public IList<NSXTSiteStatusType> RemoteConnections { get; set; }
        /// <summary>
        /// Status of synchronization between active and standby sites.
        /// </summary>
        [JsonProperty(PropertyName = "active_standby_sync_statuses", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Status of synchronization between active and standby sites.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTActiveStandbySyncStatusType> ActiveStandbySyncStatuses { get; set; }
    }
}