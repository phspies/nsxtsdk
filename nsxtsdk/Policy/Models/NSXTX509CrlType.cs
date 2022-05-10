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
    /// A CRL is a time-stamped list identifying revoked certificates.
    /// </summary>
    [NSXTProperty(Description: @"A CRL is a time-stamped list identifying revoked certificates.")]
    public class NSXTX509CrlType 
    {
        /// <summary>
        /// Next update time for the CRL.
        /// </summary>
        [JsonProperty(PropertyName = "next_update")]
        public string? NextUpdate { get; set; }
        /// <summary>
        /// CRL's version number either 1 or 2.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
        /// <summary>
        /// List of X509CrlEntry.
        /// </summary>
        [JsonProperty(PropertyName = "crl_entries")]
        public IList<NSXTX509CrlEntryType> CrlEntries { get; set; }
        /// <summary>
        /// Issuer's distinguished name. (DN)
        /// </summary>
        [JsonProperty(PropertyName = "issuer")]
        public string? Issuer { get; set; }
    }
}
