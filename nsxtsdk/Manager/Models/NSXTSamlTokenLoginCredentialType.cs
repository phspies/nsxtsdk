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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSamlTokenLoginCredentialType : NSXTLoginCredentialType
    {
        public NSXTSamlTokenLoginCredentialType()
        {
        }
        /// <summary>
        /// The saml token to login to server.
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        [NSXTProperty(IsRequired: false, Description: @"The saml token to login to server.")]
        public string? Token { get; set; }
        /// <summary>
        /// Thumbprint of the server.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        [NSXTProperty(IsRequired: false, Description: @"Thumbprint of the server.")]
        public string? Thumbprint { get; set; }
    }
}