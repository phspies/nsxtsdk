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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// A CRL is a time-stamped list identifying revoked certificates.
    /// </summary>
    [NSXTProperty(Description: @"A CRL is a time-stamped list identifying revoked certificates.")]
    public class NSXTX509CrlType 
    {
        public NSXTX509CrlType()
        {
        }
        /// <summary>
        /// Next update time for the CRL.
        /// </summary>
        [JsonProperty(PropertyName = "next_update")]
        [NSXTProperty(IsRequired: false, Description: @"Next update time for the CRL.")]
        public string? NextUpdate { get; set; }
        /// <summary>
        /// CRL's version number either 1 or 2.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        [NSXTProperty(IsRequired: false, Description: @"CRL&apos;s version number either 1 or 2.")]
        public string? Version { get; set; }
        /// <summary>
        /// List of X509CrlEntry.
        /// </summary>
        [JsonProperty(PropertyName = "crl_entries")]
        [NSXTProperty(IsRequired: false, Description: @"List of X509CrlEntry.")]
        public IList<NSXTX509CrlEntryType> CrlEntries { get; set; }
        /// <summary>
        /// Issuer's distinguished name. (DN)
        /// </summary>
        [JsonProperty(PropertyName = "issuer")]
        [NSXTProperty(IsRequired: false, Description: @"Issuer&apos;s distinguished name. (DN)")]
        public string? Issuer { get; set; }
    }
}
