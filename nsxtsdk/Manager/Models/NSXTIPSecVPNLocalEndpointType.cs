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
    public class NSXTIPSecVPNLocalEndpointType : NSXTManagedResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ipsec_vpn_service_id", Required = Required.AllowNull)]
        public NSXTResourceReferenceType IpsecVpnServiceId { get; set; }
        /// <summary>
        /// Certificate authority (CA) identifier list to verify peer certificates.
        /// </summary>
        [JsonProperty(PropertyName = "trust_ca_ids")]
        public IList<string> TrustCaIds { get; set; }
        /// <summary>
        /// Local identifier.
        /// </summary>
        [JsonProperty(PropertyName = "local_id")]
        public string? LocalId { get; set; }
        /// <summary>
        /// IPV4 Address for local endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "local_address", Required = Required.AllowNull)]
        public string LocalAddress { get; set; }
        /// <summary>
        /// Site certificate identifier.
        /// </summary>
        [JsonProperty(PropertyName = "certificate_id")]
        public string? CertificateId { get; set; }
        /// <summary>
        /// Certificate revocation list (CRL) identifier list of peer certificates.
        /// </summary>
        [JsonProperty(PropertyName = "trust_crl_ids")]
        public IList<string> TrustCrlIds { get; set; }
    }
}
