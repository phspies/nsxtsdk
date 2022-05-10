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
    public class NSXTFederationStatusType 
    {
        /// <summary>
        /// Site connection status
        /// </summary>
        [JsonProperty(PropertyName = "remote_connections")]
        public IList<NSXTSiteStatusType> RemoteConnections { get; set; }
        /// <summary>
        /// Status of synchronization between active and standby sites.
        /// </summary>
        [JsonProperty(PropertyName = "active_standby_sync_statuses", Required = Required.AllowNull)]
        public IList<NSXTActiveStandbySyncStatusType> ActiveStandbySyncStatuses { get; set; }
    }
}
