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
    public class NSXTLBJwtCertificateKeyType : NSXTLBJwtKeyType
    {
        /// <summary>
        /// Certificate identifier
        /// </summary>
        [JsonProperty(PropertyName = "certificate_path", Required = Required.AllowNull)]
        public string CertificatePath { get; set; }
    }
}
