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
    /// Parameters needed to specify a PKCE OAuth2 client.
    /// </summary>
    [NSXTProperty(Description: @"Parameters needed to specify a PKCE OAuth2 client.")]
    public class NSXTPublicClientInfoType 
    {
        /// <summary>
        /// The org id for this client-id, typically a UUID.
        /// </summary>
        [JsonProperty(PropertyName = "default_org_id", Required = Required.AllowNull)]
        public string DefaultOrgId { get; set; }
        /// <summary>
        /// The set of redirect URI's configured for this client_id.
        /// </summary>
        [JsonProperty(PropertyName = "redirect_uris", Required = Required.AllowNull)]
        public IList<string> RedirectUris { get; set; }
        /// <summary>
        /// The client-id to use with CSP, identified with base_url.
        /// </summary>
        [JsonProperty(PropertyName = "client_id", Required = Required.AllowNull)]
        public string ClientId { get; set; }
        /// <summary>
        /// The symbolic org id for enterprise admins.
        /// </summary>
        [JsonProperty(PropertyName = "ea_org_id", Required = Required.AllowNull)]
        public string EaOrgId { get; set; }
        /// <summary>
        /// The symbolic org id SRE (Site Reliability Engineer).
        /// </summary>
        [JsonProperty(PropertyName = "sre_org_id", Required = Required.AllowNull)]
        public string SreOrgId { get; set; }
        /// <summary>
        /// The symbolic org id for GSS (Global Support Services).
        /// </summary>
        [JsonProperty(PropertyName = "gss_org_id", Required = Required.AllowNull)]
        public string GssOrgId { get; set; }
        /// <summary>
        /// Protocol and domain name (or IP address) of CSP, for e.g., https://console.cloud.vmware.com.
        /// </summary>
        [JsonProperty(PropertyName = "base_url", Required = Required.AllowNull)]
        public string BaseUrl { get; set; }
    }
}
