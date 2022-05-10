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
    public class NSXTCrlObjectDataType : NSXTManagedResourceType
    {
        /// <summary>
        /// The type of the CRL. It can be "OneCRL" or "X509" (default).
        /// </summary>
        [JsonProperty(PropertyName = "crl_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTCrlObjectDataCrlTypeEnumType? CrlType { get; set; }
        /// <summary>
        /// PEM encoded CRL data.
        /// </summary>
        [JsonProperty(PropertyName = "pem_encoded")]
        public string? PemEncoded { get; set; }
        /// <summary>
        /// JSON-encoded OneCRL-like object
        /// </summary>
        [JsonProperty(PropertyName = "one_crl")]
        public string? OneCrl { get; set; }
    }
}
