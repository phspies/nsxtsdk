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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLbSslCipherAndProtocolListResultType : NSXTListResultType
    {
        /// <summary>
        /// List of SSL ciphers
        /// </summary>
        [JsonProperty(PropertyName = "ciphers", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"List of SSL ciphers")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTLbSslCipherInfoType> Ciphers { get; set; }
        /// <summary>
        /// List of SSL protocols
        /// </summary>
        [JsonProperty(PropertyName = "protocols", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"List of SSL protocols")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTLbSslProtocolInfoType> Protocols { get; set; }
    }
}