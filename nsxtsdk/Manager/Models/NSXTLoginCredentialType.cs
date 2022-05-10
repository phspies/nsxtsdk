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
    /// Base type for various login credential types
    /// </summary>
    [NSXTProperty(Description: @"Base type for various login credential types")]
    public class NSXTLoginCredentialType 
    {
        /// <summary>
        /// Possible values are 'UsernamePasswordLoginCredential', 'VerifiableAsymmetricLoginCredential', 'SessionLoginCredential'.
        /// </summary>
        [JsonProperty(PropertyName = "credential_type", Required = Required.AllowNull)]
        public string CredentialType { get; set; }
    }
}
