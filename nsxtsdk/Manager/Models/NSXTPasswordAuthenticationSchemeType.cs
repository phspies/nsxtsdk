// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPasswordAuthenticationSchemeType : NSXTAuthenticationSchemeType
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
        public NSXTPasswordAuthenticationSchemeSchemeNameEnumType SchemeName { get; set; }
        /// <summary>
        /// Password to authenticate with
        /// </summary>
        public string? Password { get; set; }
    }
}
