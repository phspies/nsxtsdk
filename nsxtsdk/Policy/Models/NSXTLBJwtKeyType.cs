using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// LBJwtKey specifies the symmetric key or asymmetric public key used to
        /// decrypt the data in JWT.
    /// </summary>
    [NSXTProperty(Description: @"LBJwtKey specifies the symmetric key or asymmetric public key used todecrypt the data in JWT.")]
    public class NSXTLBJwtKeyType 
    {
        /// <summary>
        /// The property is used to identify JWT key type.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbjwtKeyTypeEnumType Type { get; set; }
    }
}
