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
    public class NSXTCertificateProfileType : NSXTResourceType
    {
        /// <summary>
        /// True if this is for a cluster certificate
        /// </summary>
        [JsonProperty(PropertyName = "cluster_certificate")]
        public bool? ClusterCertificate { get; set; }
        /// <summary>
        /// List of types of node this certificate applies to.
        /// </summary>
        [JsonProperty(PropertyName = "node_type")]
        public IList<string> NodeType { get; set; }
        /// <summary>
        /// Certificate Profile Name
        /// </summary>
        [JsonProperty(PropertyName = "profile_name")]
        public string? ProfileName { get; set; }
        /// <summary>
        /// Indicating whether this certificate is used for server-auth, client-auth or both.
        /// </summary>
        [JsonProperty(PropertyName = "extended_key_usage")]
        public IList<string> ExtendedKeyUsage { get; set; }
        /// <summary>
        /// Unique Service Type
        /// </summary>
        [JsonProperty(PropertyName = "service_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTCertificateProfileServiceTypeEnumType? ServiceType { get; set; }
        /// <summary>
        /// True if the certificate used for this service-type cannot be used anywhere else.
        /// </summary>
        [JsonProperty(PropertyName = "unique_use")]
        public bool? UniqueUse { get; set; }
    }
}
