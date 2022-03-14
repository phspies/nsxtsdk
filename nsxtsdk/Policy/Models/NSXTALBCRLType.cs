// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public string? Body { get; set; }
        /// <summary>
        /// Distinguished name of the issuer in the Certificate
        /// Revocation list.
        /// </summary>
        public string? DistinguishedName { get; set; }
        /// <summary>
        /// Certificate Revocation list in plain text for readability.
        /// </summary>
        public string? Text { get; set; }
        /// <summary>
        /// URL of a server that issues the Certificate Revocation
        /// list.
        /// If this is configured, CRL will be periodically downloaded
        /// either based on the configured update interval or the next
        /// update interval in the CRL.
        /// CRL itself is stored in the body.
        /// </summary>
        public string? ServerUrl { get; set; }
        /// <summary>
        /// The date when this CRL was last issued.
        /// </summary>
        public string? LastUpdate { get; set; }
        /// <summary>
        /// Last time CRL was refreshed by the system.
        /// This is an internal field used by the system.
        /// </summary>
        public string? LastRefreshed { get; set; }
        /// <summary>
        /// Cached etag to optimize the download of the CRL.
        /// </summary>
        public string? Etag { get; set; }
        /// <summary>
        /// Fingerprint of the CRL.
        /// Used to avoid configuring duplicates.
        /// </summary>
        public string? Fingerprint { get; set; }
        /// <summary>
        /// Common name of the issuer in the Certificate Revocation
        /// list.
        /// </summary>
        public string? CommonName { get; set; }
        /// <summary>
        /// The date when a newer CRL will be available.
        /// Also conveys the date after which the CRL should be
        /// considered obsolete.
        /// </summary>
        public string? NextUpdate { get; set; }
        /// <summary>
        /// Interval in minutes to check for CRL update.
        /// If not specified, interval will be 1 day.
        /// Allowed values are 30-525600.
        /// Unit is MIN.
        /// </summary>
        public long? UpdateInterval { get; set; }
    }
}
