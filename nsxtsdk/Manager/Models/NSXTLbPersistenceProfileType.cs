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
    public class NSXTLbPersistenceProfileType : NSXTManagedResourceType
    {
        /// <summary>
        /// The persistence shared flag identifies whether the persistence table
        /// is shared among virtual-servers referring this profile.
        /// If persistence shared flag is not set in the cookie persistence profile
        /// bound to a virtual server, it defaults to cookie persistence that is
        /// private to each virtual server and is qualified by the pool. This is
        /// accomplished by load balancer inserting a cookie with name in the
        /// format <name>.<virtual_server_id>.<pool_id>.
        /// If persistence shared flag is set in the cookie persistence profile, in
        /// cookie insert mode, cookie persistence could be shared across multiple
        /// virtual servers that are bound to the same pools. The cookie name would
        /// be changed to <name>.<profile-id>.<pool-id>.
        /// If persistence shared flag is not set in the sourceIp persistence
        /// profile bound to a virtual server, each virtual server that the profile
        /// is bound to maintains its own private persistence table.
        /// If persistence shared flag is set in the sourceIp persistence profile,
        /// all virtual servers the profile is bound to share the same persistence
        /// table.
        /// If persistence shared flag is not set in the generic persistence
        /// profile, the persistence entries are matched and stored in the table
        /// which is identified using both virtual server ID and profile ID.
        /// If persistence shared flag is set in the generic persistence profile,
        /// the persistence entries are matched and stored in the table which is
        /// identified using profile ID. It means that virtual servers which
        /// consume the same profile in the LbRule with this flag enabled are
        /// sharing the same persistence table.
        /// </summary>
        [JsonProperty(PropertyName = "persistence_shared")]
        public bool? PersistenceShared { get; set; }
        /// <summary>
        /// The resource_type property identifies persistence profile type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbPersistenceProfileResourceTypeEnumType ResourceType { get; set; }
    }
}
