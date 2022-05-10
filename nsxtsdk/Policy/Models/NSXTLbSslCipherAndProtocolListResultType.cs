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
    public class NSXTLbSslCipherAndProtocolListResultType : NSXTListResultType
    {
        /// <summary>
        /// List of SSL ciphers
        /// </summary>
        [JsonProperty(PropertyName = "ciphers", Required = Required.AllowNull)]
        public IList<NSXTLbSslCipherInfoType> Ciphers { get; set; }
        /// <summary>
        /// List of SSL protocols
        /// </summary>
        [JsonProperty(PropertyName = "protocols", Required = Required.AllowNull)]
        public IList<NSXTLbSslProtocolInfoType> Protocols { get; set; }
    }
}
