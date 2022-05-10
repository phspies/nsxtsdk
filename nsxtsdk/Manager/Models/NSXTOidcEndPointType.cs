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
    public class NSXTOidcEndPointType : NSXTManagedResourceType
    {
        /// <summary>
        /// The URL of the OpenID provider's userinfo endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "userinfo_endpoint")]
        public string? UserinfoEndpoint { get; set; }
        /// <summary>
        /// The list of claims that the OpenID provider supports.
        /// </summary>
        [JsonProperty(PropertyName = "claims_supported")]
        public IList<string> ClaimsSupported { get; set; }
        /// <summary>
        /// A short, unique name for this OpenID Connect end-point. OIDC endpoint names may not contain spaces. If not provided,
        /// defaults to the ID of the OidcEndPoint.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Type used to distinguish the OIDC end-points by IDP.
        /// </summary>
        [JsonProperty(PropertyName = "oidc_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTOidcEndPointOidcTypeEnumType? OidcType { get; set; }
        /// <summary>
        /// URI of the OpenID Connect end-point.
        /// </summary>
        [JsonProperty(PropertyName = "oidc_uri", Required = Required.AllowNull)]
        public string OidcUri { get; set; }
        /// <summary>
        /// The URL of the OpenID provider's token endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "token_endpoint")]
        public string? TokenEndpoint { get; set; }
        /// <summary>
        /// Thumbprint in SHA-256 format used to verify the server certificate at the URI.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint", Required = Required.AllowNull)]
        public string Thumbprint { get; set; }
        /// <summary>
        /// The URI where the JWKS document is located that has the key used to validate the JWT signature.
        /// </summary>
        [JsonProperty(PropertyName = "jwks_uri")]
        public string? JwksUri { get; set; }
        /// <summary>
        /// The URL of the OpenID provider's authorization endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "authorization_endpoint")]
        public string? AuthorizationEndpoint { get; set; }
        /// <summary>
        /// When specified this role or roles are used instead of the nsx-role in the JWT
        /// </summary>
        [JsonProperty(PropertyName = "override_roles")]
        public IList<string> OverrideRoles { get; set; }
        /// <summary>
        /// Issuer of the JWT tokens for the given type. This field is fetched from the meta-data located at the oidc_uri.
        /// </summary>
        [JsonProperty(PropertyName = "issuer")]
        public string? Issuer { get; set; }
    }
}
