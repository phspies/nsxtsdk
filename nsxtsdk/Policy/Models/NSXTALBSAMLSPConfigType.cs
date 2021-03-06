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
    /// Advanced load balancer SAMLSPConfig object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SAMLSPConfig object")]
    public class NSXTALBSAMLSPConfigType 
    {
        /// <summary>
        /// SAML Single Signon URL to be programmed on the IDP.
        /// </summary>
        [JsonProperty(PropertyName = "single_signon_url", Required = Required.AllowNull)]
        public string SingleSignonUrl { get; set; }
        /// <summary>
        /// Globally unique SAML entityID for this node.
        /// The SAML application entity ID on the IDP should match
        /// this.
        /// </summary>
        [JsonProperty(PropertyName = "entity_id", Required = Required.AllowNull)]
        public string EntityId { get; set; }
        /// <summary>
        /// Key to generate the cookie.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public IList<NSXTALBHttpCookiePersistenceKeyType> Key { get; set; }
        /// <summary>
        /// SP will use this SSL certificate to sign requests going to
        /// the IdP and decrypt the assertions coming from IdP.
        /// It is a reference to an object of type
        /// SSLKeyAndCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "signing_ssl_key_and_certificate_path")]
        public string? SigningSslKeyAndCertificatePath { get; set; }
        /// <summary>
        /// SAML SP metadata for this application.
        /// </summary>
        [JsonProperty(PropertyName = "sp_metadata")]
        public string? SpMetadata { get; set; }
        /// <summary>
        /// HTTP cookie name for authenticated session.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_name")]
        public string? CookieName { get; set; }
        /// <summary>
        /// Cookie timeout in minutes.
        /// Allowed values are 1-1440.
        /// Unit is MIN.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 60.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_timeout")]
        public long? CookieTimeout { get; set; }
        /// <summary>
        /// By enabling this field IdP can control how long the SP
        /// session can exist through the SessionNotOnOrAfter field in
        /// the AuthNStatement of SAML Response.
        /// </summary>
        [JsonProperty(PropertyName = "use_idp_session_timeout")]
        public bool? UseIdpSessionTimeout { get; set; }
    }
}
