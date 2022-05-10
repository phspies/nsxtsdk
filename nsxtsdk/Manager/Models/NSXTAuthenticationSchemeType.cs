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
    public class NSXTAuthenticationSchemeType 
    {
        /// <summary>
        /// Authentication scheme name
        /// </summary>
        [JsonProperty(PropertyName = "scheme_name", Required = Required.AllowNull)]
        public string SchemeName { get; set; }
    }
}
