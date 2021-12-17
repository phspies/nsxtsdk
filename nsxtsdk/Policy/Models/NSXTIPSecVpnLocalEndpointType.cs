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
    public class NSXTIPSecVpnLocalEndpointType : NSXTPolicyConfigResourceType
    {
        public NSXTIPSecVpnLocalEndpointType()
        {
        }
        /// <summary>
        /// Local identifier.
        /// </summary>
        [JsonProperty(PropertyName = "local_id")]
        [NSXTProperty(IsRequired: false, Description: @"Local identifier.")]
        public string? LocalId { get; set; }
        /// <summary>
        /// List of policy paths referencing certificate revocation list (CRL) to peer certificates.
        /// </summary>
        [JsonProperty(PropertyName = "trust_crl_paths")]
        [NSXTProperty(IsRequired: false, Description: @"List of policy paths referencing certificate revocation list (CRL) to peer certificates.")]
        public IList<string> TrustCrlPaths { get; set; }
        /// <summary>
        /// Policy path referencing site certificate.
        /// </summary>
        [JsonProperty(PropertyName = "certificate_path")]
        [NSXTProperty(IsRequired: false, Description: @"Policy path referencing site certificate.")]
        public string? CertificatePath { get; set; }
        /// <summary>
        /// Scope attribute refers to the Policy path identifying the LocaleService of specific site where all the local end point
        /// configurations will be realized. In federation, all the configuration done for the local endpoint on GM will be realized
        /// based on the scope at the corresponding LM. Local endpoint without any scope will be realized on all sites. This
        /// attribute will not be applicable on LM.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        [NSXTProperty(IsRequired: false, Description: @"Scope attribute refers to the Policy path identifying the LocaleService of specific site where all the local end point configurations will be realized. In federation, all the configuration done for the local endpoint on GM will be realized based on the scope at the corresponding LM. Local endpoint without any scope will be realized on all sites. This attribute will not be applicable on LM.")]
        public string? Scope { get; set; }
        /// <summary>
        /// IPV4 Address of local endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "local_address", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"IPV4 Address of local endpoint.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string LocalAddress { get; set; }
        /// <summary>
        /// List of policy paths referencing certificate authority (CA) to verify peer certificates.
        /// </summary>
        [JsonProperty(PropertyName = "trust_ca_paths")]
        [NSXTProperty(IsRequired: false, Description: @"List of policy paths referencing certificate authority (CA) to verify peer certificates.")]
        public IList<string> TrustCaPaths { get; set; }
    }
}
