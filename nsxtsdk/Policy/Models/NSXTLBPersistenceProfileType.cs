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
    [JsonConverter(typeof(JsonInheritanceConverter), "resource_type")]
    [JsonInheritanceAttribute("LBCookiePersistenceProfile", typeof(NSXTLBCookiePersistenceProfileType))]
    [JsonInheritanceAttribute("LBSourceIpPersistenceProfile", typeof(NSXTLBSourceIpPersistenceProfileType))]
    [JsonInheritanceAttribute("LBGenericPersistenceProfile", typeof(NSXTLBGenericPersistenceProfileType))]
    [NSXTProperty(Description: @"")]
    public class NSXTLBPersistenceProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Persistence shared setting indicates that all LBVirtualServers
        /// that consume this LBPersistenceProfile should share the same
        /// persistence mechanism when enabled.  Meaning, persistence entries of
        /// a client accessing one virtual server will also affect the same
        /// client's connections to a different virtual server. For example, say
        /// there are two virtual servers vip-ip1:80 and vip-ip1:8080 bound to
        /// the same Group g1 consisting of two servers (s11:80 and s12:80). By
        /// default, each virtual server will have its own persistence table or
        /// cookie. So, in the earlier example, there will be two tables
        /// (vip-ip1:80, p1) and (vip-ip1:8080, p1) or cookies. So, if a client
        /// connects to vip1:80 and later connects to vip1:8080, the second
        /// connection may be sent to a different server than the first.  When
        /// persistence_shared is enabled, then the second connection will always
        /// connect to the same server as the original connection. For COOKIE
        /// persistence type, the same cookie will be shared by multiple virtual
        /// servers. For SOURCE_IP persistence type, the persistence table will
        /// be shared across virtual servers. For GENERIC persistence type, the
        /// persistence table will be shared across virtual servers which consume
        /// the same persistence profile in LBRule actions.
        /// </summary>
        [JsonProperty(PropertyName = "persistence_shared")]
        public bool? PersistenceShared { get; set; }
        /// <summary>
        /// The resource_type property identifies persistence profile type.
        /// LBCookiePersistenceProfile and LBGenericPersistenceProfile are
        /// deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbpersistenceProfileResourceTypeEnumType ResourceType { get; set; }
    }
}
