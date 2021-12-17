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
    public class NSXTCaBundleType : NSXTPolicyConfigResourceType
    {
        public NSXTCaBundleType()
        {
        }
        /// <summary>
        /// X509Certificates in the bundle
        /// </summary>
        [JsonProperty(PropertyName = "certificates")]
        [NSXTProperty(IsRequired: false, Description: @"X509Certificates in the bundle")]
        public IList<NSXTX509CertificateType> Certificates { get; set; }
        /// <summary>
        /// The earliest time in epoch milliseconds at which a certificate becomes invalid.
        /// </summary>
        [JsonProperty(PropertyName = "earliest_not_after")]
        [NSXTProperty(IsRequired: false, Description: @"The earliest time in epoch milliseconds at which a certificate becomes invalid.")]
        public long? EarliestNotAfter { get; set; }
        /// <summary>
        /// Times for each certificate in the bundle at which the certificate becomes invalid.
        /// </summary>
        [JsonProperty(PropertyName = "not_after_list")]
        [NSXTProperty(IsRequired: false, Description: @"Times for each certificate in the bundle at which the certificate becomes invalid.")]
        public long? NotAfterList { get; set; }
        /// <summary>
        /// PEM-encoded CA bundle certificates.
        /// </summary>
        [JsonProperty(PropertyName = "pem_encoded", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"PEM-encoded CA bundle certificates.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PemEncoded { get; set; }
    }
}
