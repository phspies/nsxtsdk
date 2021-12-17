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
    public class NSXTALBSSLKeyAndCertificateApiResponseType : NSXTListResultType
    {
        public NSXTALBSSLKeyAndCertificateApiResponseType()
        {
        }
        /// <summary>
        /// count
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        [NSXTProperty(IsRequired: false, Description: @"count")]
        public int? Count { get; set; }
        /// <summary>
        /// Array of SSLKeyAndCertificate
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        [NSXTProperty(IsRequired: false, Description: @"Array of SSLKeyAndCertificate")]
        public IList<NSXTALBSSLKeyAndCertificateType> Results { get; set; }
    }
}
