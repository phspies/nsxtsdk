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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTCrlType : NSXTManagedResourceType
    {
        /// <summary>
        /// Certificates revoked by subject and public key hash
        /// </summary>
        public IList<NSXTSubjectPublicKeyHashType> DetailsRevokedBySubjectAndPublicKeyHash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTX509CrlType Details { get; set; }
        /// <summary>
        /// PEM encoded CRL data.
        /// </summary>
        public string? PemEncoded { get; set; }
        /// <summary>
        /// JSON-encoded OneCRL-like object
        /// </summary>
        public string? OneCrl { get; set; }
        /// <summary>
        /// The type of the CRL. It can be "OneCRL" or "X509" (default).
        /// </summary>
        public NSXTCrlCrlTypeEnumType? CrlType { get; set; }
        /// <summary>
        /// Certificates revoked by issuer and serial number
        /// </summary>
        public IList<NSXTIssuerSerialNumberType> DetailsRevokedByIssuerAndSerialNumber { get; set; }
    }
}
