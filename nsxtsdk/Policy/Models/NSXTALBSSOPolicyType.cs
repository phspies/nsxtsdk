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
    public class NSXTALBSSOPolicyType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "authorization_policy")]
        public NSXTALBAuthorizationPolicyType AuthorizationPolicy { get; set; }
        /// <summary>
        /// SSO Policy Type.
        /// Enum options - SSO_TYPE_SAML, SSO_TYPE_PINGACCESS,
        /// SSO_TYPE_JWT.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as SSO_TYPE_SAML.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbssopolicyTypeEnumType? Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "authentication_policy", Required = Required.AllowNull)]
        public NSXTALBAuthenticationPolicyType AuthenticationPolicy { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
    }
}
