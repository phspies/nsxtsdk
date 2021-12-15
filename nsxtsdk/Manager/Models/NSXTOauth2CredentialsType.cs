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
    /// Oauth2 Account Credentials
    /// </summary>
    [NSXTProperty(Description: @"Oauth2 Account Credentials")]
    public class NSXTOauth2CredentialsType 
    {
        /// <summary>
        /// Client secret, that will be used for authentication in AWS environment. Can be some passphrase.
        /// </summary>
        [JsonProperty(PropertyName = "client_secret")]
        [NSXTProperty(IsRequired: false, Description: @"Client secret, that will be used for authentication in AWS environment. Can be some passphrase.")]
        public string? ClientSecret { get; set; }
        /// <summary>
        /// Client ID, that will be used for authentication in AWS environment,
        /// </summary>
        [JsonProperty(PropertyName = "client_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Client ID, that will be used for authentication in AWS environment,")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ClientId { get; set; }
    }
}
