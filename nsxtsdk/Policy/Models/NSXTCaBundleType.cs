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
    public class NSXTCaBundleType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// X509Certificates in the bundle
        /// </summary>
        [JsonProperty(PropertyName = "certificates")]
        public IList<NSXTX509CertificateType> Certificates { get; set; }
        /// <summary>
        /// The earliest time in epoch milliseconds at which a certificate becomes invalid.
        /// </summary>
        [JsonProperty(PropertyName = "earliest_not_after")]
        public long? EarliestNotAfter { get; set; }
        /// <summary>
        /// Times for each certificate in the bundle at which the certificate becomes invalid.
        /// </summary>
        [JsonProperty(PropertyName = "not_after_list")]
        public long? NotAfterList { get; set; }
        /// <summary>
        /// PEM-encoded CA bundle certificates.
        /// </summary>
        [JsonProperty(PropertyName = "pem_encoded", Required = Required.AllowNull)]
        public string PemEncoded { get; set; }
    }
}
