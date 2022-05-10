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
    public class NSXTCryptoAlgorithmType 
    {
        /// <summary>
        /// Supported key sizes for the algorithm.
        /// </summary>
        [JsonProperty(PropertyName = "key_size")]
        public long? KeySize { get; set; }
        /// <summary>
        /// Crypto algorithm name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
