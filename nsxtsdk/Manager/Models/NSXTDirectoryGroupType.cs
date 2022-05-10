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
    public class NSXTDirectoryGroupType : NSXTManagedResourceType
    {
        /// <summary>
        /// Domain sync node under which this directory group is located. We currently sync only from Root node and hence this
        /// attribute doesn't have a specific value set.
        /// </summary>
        [JsonProperty(PropertyName = "domain_sync_node_id")]
        public string? DomainSyncNodeId { get; set; }
        /// <summary>
        /// Directory group distinguished name
        /// </summary>
        [JsonProperty(PropertyName = "distinguished_name", Required = Required.AllowNull)]
        public string DistinguishedName { get; set; }
        /// <summary>
        /// Domain ID this directory group belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "domain_id", Required = Required.AllowNull)]
        public string DomainId { get; set; }
        /// <summary>
        /// Directory group resource type comes from multiple sub-classes extending this base class. For example, DirectoryAdGroup
        /// is one accepted resource_type. If there are more sub-classes defined, they will also be accepted resource_type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        public string ResourceType { get; set; }
        /// <summary>
        /// Each active directory domain has a domain naming context (NC), which contains domain-specific data. The root of this
        /// naming context is represented by a domain's distinguished name (DN) and is typically referred to as the NC head.
        /// </summary>
        [JsonProperty(PropertyName = "domain_name", Required = Required.AllowNull)]
        public string DomainName { get; set; }
    }
}
