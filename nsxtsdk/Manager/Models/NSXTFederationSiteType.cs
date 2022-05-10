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
    /// Site information.
    /// </summary>
    [NSXTProperty(Description: @"Site information.")]
    public class NSXTFederationSiteType 
    {
        /// <summary>
        /// Is site local
        /// </summary>
        [JsonProperty(PropertyName = "is_local", Required = Required.AllowNull)]
        public bool IsLocal { get; set; }
        /// <summary>
        /// Site config version
        /// </summary>
        [JsonProperty(PropertyName = "config_version")]
        public long? ConfigVersion { get; set; }
        /// <summary>
        /// Name of the site
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Does site have active GM
        /// </summary>
        [JsonProperty(PropertyName = "active_gm", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFederationSiteActiveGmEnumType ActiveGm { get; set; }
        /// <summary>
        /// Split brain
        /// </summary>
        [JsonProperty(PropertyName = "split_brain")]
        public bool? SplitBrain { get; set; }
        /// <summary>
        /// Is site federated
        /// </summary>
        [JsonProperty(PropertyName = "is_federated", Required = Required.AllowNull)]
        public bool IsFederated { get; set; }
        /// <summary>
        /// Version of the site
        /// </summary>
        [JsonProperty(PropertyName = "site_version", Required = Required.AllowNull)]
        public string SiteVersion { get; set; }
        /// <summary>
        /// Vip ip
        /// </summary>
        [JsonProperty(PropertyName = "vip_ip")]
        public string? VipIp { get; set; }
        /// <summary>
        /// Type of node
        /// </summary>
        [JsonProperty(PropertyName = "node_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFederationSiteNodeTypeEnumType NodeType { get; set; }
        /// <summary>
        /// Hash of the trustManagerCert
        /// </summary>
        [JsonProperty(PropertyName = "cert_hash")]
        public string? CertHash { get; set; }
        /// <summary>
        /// Cluster id
        /// </summary>
        [JsonProperty(PropertyName = "cluster_id")]
        public string? ClusterId { get; set; }
        /// <summary>
        /// Cert string from trust manager
        /// </summary>
        [JsonProperty(PropertyName = "trust_manager_cert")]
        public string? TrustManagerCert { get; set; }
        /// <summary>
        /// System id
        /// </summary>
        [JsonProperty(PropertyName = "system_id", Required = Required.AllowNull)]
        public long SystemId { get; set; }
        /// <summary>
        /// Aph services in the site
        /// </summary>
        [JsonProperty(PropertyName = "aph_list", Required = Required.AllowNull)]
        public IList<NSXTAphInfoType> AphList { get; set; }
        /// <summary>
        /// Id of the site
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
    }
}
