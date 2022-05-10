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
    public class NSXTSubjectPublicKeyHashType 
    {
        /// <summary>
        /// List of SHA256 hashes of the Public Key of the revoked certificates with the specified subject.
        /// </summary>
        [JsonProperty(PropertyName = "public_key_sha256_hashes")]
        public IList<string> PublicKeySha256Hashes { get; set; }
        /// <summary>
        /// Subject Distinguished Name of the revoked certificates.
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string? Subject { get; set; }
    }
}
