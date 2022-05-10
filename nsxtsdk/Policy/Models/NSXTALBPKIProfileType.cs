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
    public class NSXTALBPKIProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Certificate Revocation Lists.
        /// </summary>
        [JsonProperty(PropertyName = "crls")]
        public IList<NSXTALBCRLType> Crls { get; set; }
        /// <summary>
        /// When enabled, Avi will only validate the revocation status
        /// of the leaf certificate using CRL.
        /// To enable validation for the entire chain, disable this
        /// option and provide all the relevant CRLs.
        /// Allowed in Basic(Allowed values- true) edition,
        /// Essentials(Allowed values- true) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "validate_only_leaf_crl")]
        public bool? ValidateOnlyLeafCrl { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// List of Certificate Authorities (Root and Intermediate)
        /// trusted that is used for certificate validation.
        /// </summary>
        [JsonProperty(PropertyName = "ca_certs")]
        public IList<NSXTALBSSLCertificateType> CaCerts { get; set; }
        /// <summary>
        /// When enabled, Avi will verify via CRL checks that
        /// certificates in the trust chain have not been revoked.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "crl_check")]
        public bool? CrlCheck { get; set; }
        /// <summary>
        /// When enabled, Avi will not trust Intermediate and Root
        /// certs presented by a client.
        /// Instead, only the chain certs configured in the Certificate
        /// Authority section will be used to verify trust of the
        /// client's cert.
        /// Allowed in Basic(Allowed values- true) edition,
        /// Essentials(Allowed values- true) edition, Enterprise
        /// edition.
        /// Special default for Basic edition is true, Essentials
        /// edition is true, Enterprise is False.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "ignore_peer_chain")]
        public bool? IgnorePeerChain { get; set; }
        /// <summary>
        /// This field describes the object's replication scope.
        /// If the field is set to false, then the object is visible
        /// within the controller-cluster and its associated
        /// service-engines.
        /// If the field is set to true, then the object is replicated
        /// across the federation.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "is_federated")]
        public bool? IsFederated { get; set; }
        /// <summary>
        /// Creator name.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
    }
}
