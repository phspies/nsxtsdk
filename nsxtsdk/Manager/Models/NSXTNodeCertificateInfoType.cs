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
    public class NSXTNodeCertificateInfoType 
    {
        /// <summary>
        /// SHA256 of certificate
        /// </summary>
        [JsonProperty(PropertyName = "certificate_sha256_thumbprint")]
        public string? CertificateSha256Thumbprint { get; set; }
        /// <summary>
        /// Certificate content
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public string? Certificate { get; set; }
        /// <summary>
        /// Entity type of this certificate
        /// </summary>
        [JsonProperty(PropertyName = "entity_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeCertificateInfoEntityTypeEnumType? EntityType { get; set; }
    }
}
