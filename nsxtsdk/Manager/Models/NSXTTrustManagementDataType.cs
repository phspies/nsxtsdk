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
    public class NSXTTrustManagementDataType 
    {
        /// <summary>
        /// List of supported algorithms.
        /// </summary>
        [JsonProperty(PropertyName = "supported_algorithms")]
        public IList<NSXTCryptoAlgorithmType> SupportedAlgorithms { get; set; }
    }
}
