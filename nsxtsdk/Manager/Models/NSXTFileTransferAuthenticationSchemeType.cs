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
    /// Remote server authentication details
    /// </summary>
    [NSXTProperty(Description: @"Remote server authentication details")]
    public class NSXTFileTransferAuthenticationSchemeType 
    {
        /// <summary>
        /// User name to authenticate with
        /// </summary>
        [JsonProperty(PropertyName = "username", Required = Required.AllowNull)]
        public string Username { get; set; }
        /// <summary>
        /// Authentication scheme name
        /// </summary>
        [JsonProperty(PropertyName = "scheme_name", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFileTransferAuthenticationSchemeSchemeNameEnumType SchemeName { get; set; }
        /// <summary>
        /// Password to authenticate with
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
    }
}
