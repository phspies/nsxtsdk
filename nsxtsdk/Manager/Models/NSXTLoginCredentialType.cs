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
    /// Base type for various login credential types
    /// </summary>
    [NSXTProperty(Description: @"Base type for various login credential types")]
    public class NSXTLoginCredentialType 
    {
        /// <summary>
        /// Possible values are 'UsernamePasswordLoginCredential', 'VerifiableAsymmetricLoginCredential', 'SessionLoginCredential'.
        /// </summary>
        [JsonProperty(PropertyName = "credential_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Possible values are &apos;UsernamePasswordLoginCredential&apos;, &apos;VerifiableAsymmetricLoginCredential&apos;, &apos;SessionLoginCredential&apos;.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CredentialType { get; set; }
    }
}
