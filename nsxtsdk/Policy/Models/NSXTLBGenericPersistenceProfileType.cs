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
    public class NSXTLBGenericPersistenceProfileType : NSXTLBPersistenceProfileType
    {
        /// <summary>
        /// The mirroring enabled flag is to synchronize persistence entries.
        /// Persistence entries are not synchronized to the HA peer by default.
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
