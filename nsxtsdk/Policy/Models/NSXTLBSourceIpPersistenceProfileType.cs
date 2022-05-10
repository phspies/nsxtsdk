using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLBSourceIpPersistenceProfileType : NSXTLBPersistenceProfileType
    {
        /// <summary>
        /// Persistence purge setting.
        /// </summary>
        [JsonProperty(PropertyName = "purge")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbsourceIpPersistenceProfilePurgeEnumType? Purge { get; set; }
        /// <summary>
        /// Persistence entries are not synchronized to the HA peer by default.
        /// The property is deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "ha_persistence_mirroring_enabled")]
        public bool? HaPersistenceMirroringEnabled { get; set; }
        /// <summary>
        /// When all connections complete (reference count reaches 0), persistence
        /// entry timer is started with the expiration time.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public long? Timeout { get; set; }
    }
}
