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
    /// Advanced load balancer SamlServiceProviderSettings object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SamlServiceProviderSettings object")]
    public class NSXTALBSamlServiceProviderSettingsType 
    {
        /// <summary>
        /// Service Provider Organization Name.
        /// </summary>
        [JsonProperty(PropertyName = "org_name")]
        public string? OrgName { get; set; }
        /// <summary>
        /// Service Provider technical contact email.
        /// </summary>
        [JsonProperty(PropertyName = "tech_contact_email")]
        public string? TechContactEmail { get; set; }
        /// <summary>
        /// Service Provider node information.
        /// </summary>
        [JsonProperty(PropertyName = "sp_nodes")]
        public IList<NSXTALBSamlServiceProviderNodeType> SpNodes { get; set; }
        /// <summary>
        /// Service Provider Organization Display Name.
        /// </summary>
        [JsonProperty(PropertyName = "org_display_name")]
        public string? OrgDisplayName { get; set; }
        /// <summary>
        /// Service Provider Organization URL.
        /// </summary>
        [JsonProperty(PropertyName = "org_url")]
        public string? OrgUrl { get; set; }
        /// <summary>
        /// Service Provider technical contact name.
        /// </summary>
        [JsonProperty(PropertyName = "tech_contact_name")]
        public string? TechContactName { get; set; }
        /// <summary>
        /// FQDN if entity type is DNS_FQDN .
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string? Fqdn { get; set; }
        /// <summary>
        /// Type of SAML endpoint.
        /// Enum options - AUTH_SAML_CLUSTER_VIP, AUTH_SAML_DNS_FQDN,
        /// AUTH_SAML_APP_VS.
        /// </summary>
        [JsonProperty(PropertyName = "saml_entity_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbsamlServiceProviderSettingsSamlEntityTypeEnumType? SamlEntityType { get; set; }
    }
}
