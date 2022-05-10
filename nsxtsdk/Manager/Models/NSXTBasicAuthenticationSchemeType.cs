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
    public class NSXTBasicAuthenticationSchemeType : NSXTAuthenticationSchemeType
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
        public NSXTBasicAuthenticationSchemeSchemeNameEnumType SchemeName { get; set; }
        /// <summary>
        /// Password to authenticate with
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
    }
}
