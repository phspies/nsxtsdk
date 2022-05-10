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
    /// Oauth2 Account Credentials
    /// </summary>
    [NSXTProperty(Description: @"Oauth2 Account Credentials")]
    public class NSXTOauth2CredentialsType 
    {
        /// <summary>
        /// Client secret, that will be used for authentication in AWS environment. Can be some passphrase.
        /// </summary>
        [JsonProperty(PropertyName = "client_secret")]
        public string? ClientSecret { get; set; }
        /// <summary>
        /// Client ID, that will be used for authentication in AWS environment,
        /// </summary>
        [JsonProperty(PropertyName = "client_id", Required = Required.AllowNull)]
        public string ClientId { get; set; }
    }
}
