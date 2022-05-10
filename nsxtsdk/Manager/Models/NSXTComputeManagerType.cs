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
    public class NSXTComputeManagerType : NSXTManagedResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "credential")]
        public NSXTLoginCredentialType Credential { get; set; }
        /// <summary>
        /// If the compute manager is VC and need to set set as OIDC provider for NSX then
        /// this flag should be set as true. This is specific to wcp feature, should be
        /// enabled when this feature is being used.
        /// </summary>
        [JsonProperty(PropertyName = "set_as_oidc_provider")]
        public bool? SetAsOidcProvider { get; set; }
        /// <summary>
        /// Specifies the maximum access level allowed for calls from compute manager
        /// to NSX using the OIDC provider.
        /// </summary>
        [JsonProperty(PropertyName = "access_level_for_oidc")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTComputeManagerAccessLevelForOidcEnumType? AccessLevelForOidc { get; set; }
        /// <summary>
        /// Specifies https port of the reverse proxy to connect to compute manager.
        /// For e.g. In case of VC, this port can be retrieved from this config
        /// file /etc/vmware-rhttpproxy/config.xml.
        /// </summary>
        [JsonProperty(PropertyName = "reverse_proxy_https_port")]
        public long? ReverseProxyHttpsPort { get; set; }
        /// <summary>
        /// Enable this flag to create service account user on compute manager. This is
        /// required by features such as vSphere Lifecycle Manager for authentication with
        /// vAPIs from nsx.
        /// </summary>
        [JsonProperty(PropertyName = "create_service_account")]
        public bool? CreateServiceAccount { get; set; }
        /// <summary>
        /// Key-Value map of additional specific properties of compute manager
        /// </summary>
        [JsonProperty(PropertyName = "origin_properties")]
        public IList<NSXTKeyValuePairType> OriginProperties { get; set; }
        /// <summary>
        /// Compute manager type like vCenter
        /// </summary>
        [JsonProperty(PropertyName = "origin_type", Required = Required.AllowNull)]
        public string OriginType { get; set; }
        /// <summary>
        /// IP address or hostname of compute manager
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        public string Server { get; set; }
    }
}
