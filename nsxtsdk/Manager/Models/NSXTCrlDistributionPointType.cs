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
    public class NSXTCrlDistributionPointType : NSXTManagedResourceType
    {
        /// <summary>
        /// CRL Distribution Point URI where to fetch the CRL.
        /// </summary>
        [JsonProperty(PropertyName = "cdp_uri")]
        public string? CdpUri { get; set; }
        /// <summary>
        /// Issuer of the CRL, referring to the CA.
        /// </summary>
        [JsonProperty(PropertyName = "issuer")]
        public string? Issuer { get; set; }
    }
}
