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
    public class NSXTSwitchingToVmcModeParametersType : NSXTNodeModeType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ea_org")]
        public NSXTOrgInfoType EaOrg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "sre_org")]
        public NSXTOrgInfoType SreOrg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "gss_org")]
        public NSXTOrgInfoType GssOrg { get; set; }
        /// <summary>
        /// This CSP end-point returns the identity provider's logout url. In order to logout, an explicit redirect to this url is
        /// needed.
        /// </summary>
        [JsonProperty(PropertyName = "csp_logout_uri")]
        public string? CspLogoutUri { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "auth_code")]
        public NSXTOauth2CredentialsType AuthCode { get; set; }
        /// <summary>
        /// CSP time drift in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "csp_time_drift")]
        public long? CspTimeDrift { get; set; }
        /// <summary>
        /// List of whitelist IPs for basic auth
        /// </summary>
        [JsonProperty(PropertyName = "basic_auth_whitelist_ips")]
        public IList<string> BasicAuthWhitelistIps { get; set; }
        /// <summary>
        /// SDDC id
        /// </summary>
        [JsonProperty(PropertyName = "sddc_id")]
        public string? SddcId { get; set; }
        /// <summary>
        /// Port of PoP (Point-of-Presence) Http proxy server
        /// </summary>
        [JsonProperty(PropertyName = "proxy_port")]
        public long? ProxyPort { get; set; }
        /// <summary>
        /// Node Mode type
        /// </summary>
        [JsonProperty(PropertyName = "resource_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSwitchingToVmcModeParametersResourceTypeEnumType? ResourceType { get; set; }
        /// <summary>
        /// Relative path on CSP server to the Org location. Can be "/csp/gateway/am/api/orgs/".
        /// </summary>
        [JsonProperty(PropertyName = "csp_org_uri")]
        public string? CspOrgUri { get; set; }
        /// <summary>
        /// Org ID of a Client - commonly UUID.
        /// </summary>
        [JsonProperty(PropertyName = "default_org_id")]
        public string? DefaultOrgId { get; set; }
        /// <summary>
        /// IP/host of PoP (Point-of-Presence) HTTP proxy server
        /// </summary>
        [JsonProperty(PropertyName = "proxy_host")]
        public string? ProxyHost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "public_client_info")]
        public NSXTPublicClientInfoType PublicClientInfo { get; set; }
        /// <summary>
        /// Protocol and domain name (or IP address) of a CSP server, like "https://console-stg.cloud.vmware.com".
        /// </summary>
        [JsonProperty(PropertyName = "base_url")]
        public string? BaseUrl { get; set; }
        /// <summary>
        /// CSP endpoint that returns a list of public keys in jwks format. These keys are used in an application to validate that
        /// the access-token is valid.
        /// </summary>
        [JsonProperty(PropertyName = "csp_public_key_uri")]
        public string? CspPublicKeyUri { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "csp_client_credential")]
        public NSXTOauth2CredentialsType CspClientCredential { get; set; }
        /// <summary>
        /// This endpoint is used with browser redirection only. It discovers the user's Identity Provider (IdP) and sends the user
        /// to the IdP login page. It is the starting point of the OAuth 2.0 flow to authenticate end users from an application.
        /// </summary>
        [JsonProperty(PropertyName = "csp_user_authorization_uri")]
        public string? CspUserAuthorizationUri { get; set; }
        /// <summary>
        /// When this parameter is set to true, only a change of the node mode happens without any update to the auth properties.
        /// When this param is not set to true i.e. set to false or not provided, mode change and update to the auth properties will
        /// both happen.
        /// </summary>
        [JsonProperty(PropertyName = "mode_change_only")]
        public bool? ModeChangeOnly { get; set; }
        /// <summary>
        /// List of incoming client IDs
        /// </summary>
        [JsonProperty(PropertyName = "csp_client_incoming_credentials")]
        public IList<string> CspClientIncomingCredentials { get; set; }
        /// <summary>
        /// Service definition id
        /// </summary>
        [JsonProperty(PropertyName = "service_definition_id")]
        public string? ServiceDefinitionId { get; set; }
        /// <summary>
        /// This CSP end-point exchanges one of the following grants - authorization_code, refresh_token, client_credentials or
        /// client_delegate for an access token.
        /// </summary>
        [JsonProperty(PropertyName = "csp_access_token_uri")]
        public string? CspAccessTokenUri { get; set; }
        /// <summary>
        /// This endpoint returns the content of the given access token if the token is valid. It also includes the group_ids and
        /// group_names if the client is registered with group_id, group_names scopes. It's usually /am/api/userinfo.
        /// </summary>
        [JsonProperty(PropertyName = "csp_user_info_uri")]
        public string? CspUserInfoUri { get; set; }
    }
}
