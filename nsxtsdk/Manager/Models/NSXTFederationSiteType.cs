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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Site information.
    /// </summary>
    [NSXTProperty(Description: @"Site information.")]
    public class NSXTFederationSiteType 
    {
        public NSXTFederationSiteType()
        {
        }
        /// <summary>
        /// Is site local
        /// </summary>
        [JsonProperty(PropertyName = "is_local", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Is site local")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool IsLocal { get; set; }
        /// <summary>
        /// Site config version
        /// </summary>
        [JsonProperty(PropertyName = "config_version")]
        [NSXTProperty(IsRequired: false, Description: @"Site config version")]
        public long? ConfigVersion { get; set; }
        /// <summary>
        /// Name of the site
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Name of the site")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Does site have active GM
        /// </summary>
        [JsonProperty(PropertyName = "active_gm", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Does site have active GM")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTFederationSiteActiveGmEnumType ActiveGm { get; set; }
        /// <summary>
        /// Split brain
        /// </summary>
        [JsonProperty(PropertyName = "split_brain")]
        [NSXTProperty(IsRequired: false, Description: @"Split brain")]
        public bool? SplitBrain { get; set; }
        /// <summary>
        /// Is site federated
        /// </summary>
        [JsonProperty(PropertyName = "is_federated", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Is site federated")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool IsFederated { get; set; }
        /// <summary>
        /// Version of the site
        /// </summary>
        [JsonProperty(PropertyName = "site_version", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Version of the site")]
        [System.ComponentModel.DataAnnotations.Required]
        public string SiteVersion { get; set; }
        /// <summary>
        /// Vip ip
        /// </summary>
        [JsonProperty(PropertyName = "vip_ip")]
        [NSXTProperty(IsRequired: false, Description: @"Vip ip")]
        public string? VipIp { get; set; }
        /// <summary>
        /// Type of node
        /// </summary>
        [JsonProperty(PropertyName = "node_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Type of node")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTFederationSiteNodeTypeEnumType NodeType { get; set; }
        /// <summary>
        /// Hash of the trustManagerCert
        /// </summary>
        [JsonProperty(PropertyName = "cert_hash")]
        [NSXTProperty(IsRequired: false, Description: @"Hash of the trustManagerCert")]
        public string? CertHash { get; set; }
        /// <summary>
        /// Cluster id
        /// </summary>
        [JsonProperty(PropertyName = "cluster_id")]
        [NSXTProperty(IsRequired: false, Description: @"Cluster id")]
        public string? ClusterId { get; set; }
        /// <summary>
        /// Cert string from trust manager
        /// </summary>
        [JsonProperty(PropertyName = "trust_manager_cert")]
        [NSXTProperty(IsRequired: false, Description: @"Cert string from trust manager")]
        public string? TrustManagerCert { get; set; }
        /// <summary>
        /// System id
        /// </summary>
        [JsonProperty(PropertyName = "system_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"System id")]
        [System.ComponentModel.DataAnnotations.Required]
        public long SystemId { get; set; }
        /// <summary>
        /// Aph services in the site
        /// </summary>
        [JsonProperty(PropertyName = "aph_list", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Aph services in the site")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTAphInfoType> AphList { get; set; }
        /// <summary>
        /// Id of the site
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Id of the site")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Id { get; set; }
    }
}