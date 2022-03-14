// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public bool? HaPersistenceMirroringEnabled { get; set; }
        /// <summary>
        /// When all connections complete (reference count reaches 0), persistence
        /// entry timer is started with the expiration time.
        /// </summary>
        public long? Timeout { get; set; }
    }
}
