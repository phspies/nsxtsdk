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
    /// NSX Cluster is made up of multiple cluster nodes. Each node can perform multiple functions, commonly referred to as
        /// roles. Cluster node entities are processes running in a cluster node that assist in the performance of a role. Cluster
        /// Boot Manager is a daemon that securely bootstraps and configures the entities. This type contains attributes of a
        /// cluster node entity that are relevant to the Cluster Boot Manager.
    /// </summary>
    [NSXTProperty(Description: @"NSX Cluster is made up of multiple cluster nodes. Each node can perform multiple functions, commonly referred to as roles. Cluster node entities are processes running in a cluster node that assist in the performance of a role. Cluster Boot Manager is a daemon that securely bootstraps and configures the entities. This type contains attributes of a cluster node entity that are relevant to the Cluster Boot Manager.")]
    public class NSXTClusterNodeEntityType 
    {
        /// <summary>
        /// Public certificate of the entity in PEM format
        /// </summary>
        [JsonProperty(PropertyName = "certificate", Required = Required.AllowNull)]
        public string Certificate { get; set; }
        /// <summary>
        /// UUID of the entity
        /// </summary>
        [JsonProperty(PropertyName = "entity_uuid", Required = Required.AllowNull)]
        public string EntityUuid { get; set; }
        /// <summary>
        /// Type of the entity
        /// </summary>
        [JsonProperty(PropertyName = "entity_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTClusterNodeEntityEntityTypeEnumType EntityType { get; set; }
        /// <summary>
        /// Subnet mask prefix length of the entity binds to
        /// </summary>
        [JsonProperty(PropertyName = "subnet_prefix_length")]
        public long? SubnetPrefixLength { get; set; }
        /// <summary>
        /// IP address the entity binds to
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string? IpAddress { get; set; }
        /// <summary>
        /// Domain name the entity binds to
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string? Fqdn { get; set; }
        /// <summary>
        /// Port the entity binds to
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
    }
}
