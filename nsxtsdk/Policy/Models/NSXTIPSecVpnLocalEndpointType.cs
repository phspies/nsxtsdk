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
    public class NSXTIPSecVpnLocalEndpointType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Local identifier.
        /// </summary>
        [JsonProperty(PropertyName = "local_id")]
        public string? LocalId { get; set; }
        /// <summary>
        /// List of policy paths referencing certificate revocation list (CRL) to peer certificates.
        /// </summary>
        [JsonProperty(PropertyName = "trust_crl_paths")]
        public IList<string> TrustCrlPaths { get; set; }
        /// <summary>
        /// Policy path referencing site certificate.
        /// </summary>
        [JsonProperty(PropertyName = "certificate_path")]
        public string? CertificatePath { get; set; }
        /// <summary>
        /// Scope attribute refers to the Policy path identifying the LocaleService of specific site where all the local end point
        /// configurations will be realized. In federation, all the configuration done for the local endpoint on GM will be realized
        /// based on the scope at the corresponding LM. Local endpoint without any scope will be realized on all sites. This
        /// attribute will not be applicable on LM.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string? Scope { get; set; }
        /// <summary>
        /// IPV4 Address of local endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "local_address", Required = Required.AllowNull)]
        public string LocalAddress { get; set; }
        /// <summary>
        /// List of policy paths referencing certificate authority (CA) to verify peer certificates.
        /// </summary>
        [JsonProperty(PropertyName = "trust_ca_paths")]
        public IList<string> TrustCaPaths { get; set; }
    }
}
