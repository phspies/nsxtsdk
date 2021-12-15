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
    public class NSXTLBGenericPersistenceProfileType : NSXTLBPersistenceProfileType
    {
        /// <summary>
        /// The mirroring enabled flag is to synchronize persistence entries.
        /// Persistence entries are not synchronized to the HA peer by default.
        /// </summary>
        [JsonProperty(PropertyName = "ha_persistence_mirroring_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"The mirroring enabled flag is to synchronize persistence entries.Persistence entries are not synchronized to the HA peer by default.")]
        public bool? HaPersistenceMirroringEnabled { get; set; }
        /// <summary>
        /// When all connections complete (reference count reaches 0), persistence
        /// entry timer is started with the expiration time.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        [NSXTProperty(IsRequired: false, Description: @"When all connections complete (reference count reaches 0), persistenceentry timer is started with the expiration time.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(2147483647)]
        [NSXTDefaultProperty(Default: "")]
        public long? Timeout { get; set; }
    }
}
