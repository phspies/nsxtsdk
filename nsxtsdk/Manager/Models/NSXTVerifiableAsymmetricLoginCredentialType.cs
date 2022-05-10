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
    public class NSXTVerifiableAsymmetricLoginCredentialType : NSXTLoginCredentialType
    {
        /// <summary>
        /// Asymmetric login credential
        /// </summary>
        [JsonProperty(PropertyName = "asymmetric_credential")]
        public string? AsymmetricCredential { get; set; }
        /// <summary>
        /// Credential verifier
        /// </summary>
        [JsonProperty(PropertyName = "credential_verifier")]
        public string? CredentialVerifier { get; set; }
        /// <summary>
        /// Credential key
        /// </summary>
        [JsonProperty(PropertyName = "credential_key")]
        public string? CredentialKey { get; set; }
    }
}
