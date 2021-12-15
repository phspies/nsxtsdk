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
    /// Advanced load balancer CRL object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer CRL object")]
    public class NSXTALBCRLType 
    {
        /// <summary>
        /// Certificate Revocation list from a given issuer in PEM
        /// format.
        /// This can either be configured directly or via the
        /// server_url.
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        [NSXTProperty(IsRequired: false, Description: @"Certificate Revocation list from a given issuer in PEMformat.This can either be configured directly or via theserver_url.")]
        public string? Body { get; set; }
        /// <summary>
        /// Distinguished name of the issuer in the Certificate
        /// Revocation list.
        /// </summary>
        [JsonProperty(PropertyName = "distinguished_name")]
        [NSXTProperty(IsRequired: false, Description: @"Distinguished name of the issuer in the CertificateRevocation list.")]
        public string? DistinguishedName { get; set; }
        /// <summary>
        /// Certificate Revocation list in plain text for readability.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        [NSXTProperty(IsRequired: false, Description: @"Certificate Revocation list in plain text for readability.")]
        public string? Text { get; set; }
        /// <summary>
        /// URL of a server that issues the Certificate Revocation
        /// list.
        /// If this is configured, CRL will be periodically downloaded
        /// either based on the configured update interval or the next
        /// update interval in the CRL.
        /// CRL itself is stored in the body.
        /// </summary>
        [JsonProperty(PropertyName = "server_url")]
        [NSXTProperty(IsRequired: false, Description: @"URL of a server that issues the Certificate Revocationlist.If this is configured, CRL will be periodically downloadedeither based on the configured update interval or the nextupdate interval in the CRL.CRL itself is stored in the body.")]
        public string? ServerUrl { get; set; }
        /// <summary>
        /// The date when this CRL was last issued.
        /// </summary>
        [JsonProperty(PropertyName = "last_update")]
        [NSXTProperty(IsRequired: false, Description: @"The date when this CRL was last issued.")]
        public string? LastUpdate { get; set; }
        /// <summary>
        /// Last time CRL was refreshed by the system.
        /// This is an internal field used by the system.
        /// </summary>
        [JsonProperty(PropertyName = "last_refreshed")]
        [NSXTProperty(IsRequired: false, Description: @"Last time CRL was refreshed by the system.This is an internal field used by the system.")]
        public string? LastRefreshed { get; set; }
        /// <summary>
        /// Cached etag to optimize the download of the CRL.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        [NSXTProperty(IsRequired: false, Description: @"Cached etag to optimize the download of the CRL.")]
        public string? Etag { get; set; }
        /// <summary>
        /// Fingerprint of the CRL.
        /// Used to avoid configuring duplicates.
        /// </summary>
        [JsonProperty(PropertyName = "fingerprint")]
        [NSXTProperty(IsRequired: false, Description: @"Fingerprint of the CRL.Used to avoid configuring duplicates.")]
        public string? Fingerprint { get; set; }
        /// <summary>
        /// Common name of the issuer in the Certificate Revocation
        /// list.
        /// </summary>
        [JsonProperty(PropertyName = "common_name")]
        [NSXTProperty(IsRequired: false, Description: @"Common name of the issuer in the Certificate Revocationlist.")]
        public string? CommonName { get; set; }
        /// <summary>
        /// The date when a newer CRL will be available.
        /// Also conveys the date after which the CRL should be
        /// considered obsolete.
        /// </summary>
        [JsonProperty(PropertyName = "next_update")]
        [NSXTProperty(IsRequired: false, Description: @"The date when a newer CRL will be available.Also conveys the date after which the CRL should beconsidered obsolete.")]
        public string? NextUpdate { get; set; }
        /// <summary>
        /// Interval in minutes to check for CRL update.
        /// If not specified, interval will be 1 day.
        /// Allowed values are 30-525600.
        /// Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "update_interval")]
        [NSXTProperty(IsRequired: false, Description: @"Interval in minutes to check for CRL update.If not specified, interval will be 1 day.Allowed values are 30-525600.Unit is MIN.")]
        //[System.ComponentModel.DataAnnotations.MinLength(30)]
        //[System.ComponentModel.DataAnnotations.MaxLength(525600)]
        public long? UpdateInterval { get; set; }
    }
}
