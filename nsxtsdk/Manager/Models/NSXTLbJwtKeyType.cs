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
    /// LbJwtKey specifies the symmetric key or asymmetric public key used to
        /// decrypt the data in JWT.
    /// </summary>
    [NSXTProperty(Description: @"LbJwtKey specifies the symmetric key or asymmetric public key used todecrypt the data in JWT.")]
    public class NSXTLbJwtKeyType 
    {
        /// <summary>
        /// The property is used to identify JWT key type.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbJwtKeyTypeEnumType Type { get; set; }
    }
}
