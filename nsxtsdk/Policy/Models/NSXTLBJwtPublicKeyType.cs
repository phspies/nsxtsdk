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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLBJwtPublicKeyType : NSXTLBJwtKeyType
    {
        /// <summary>
        /// Content of public key
        /// </summary>
        [JsonProperty(PropertyName = "public_key_content", Required = Required.AllowNull)]
        public string PublicKeyContent { get; set; }
    }
}
