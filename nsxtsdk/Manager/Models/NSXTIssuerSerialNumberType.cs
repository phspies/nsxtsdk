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
    public class NSXTIssuerSerialNumberType 
    {
        /// <summary>
        /// List of Certificate Serial Numbers issued by the specified issuers.
        /// </summary>
        [JsonProperty(PropertyName = "serial_numbers")]
        public IList<string> SerialNumbers { get; set; }
        /// <summary>
        /// Issuer Distinguished Name of the revoked certificates.
        /// </summary>
        [JsonProperty(PropertyName = "issuer")]
        public string? Issuer { get; set; }
    }
}
