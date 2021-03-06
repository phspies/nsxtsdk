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
    public class NSXTMetadataProxyConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Secret word or phrase to access metadata server.
        /// </summary>
        [JsonProperty(PropertyName = "secret", Required = Required.AllowNull)]
        public string Secret { get; set; }
        /// <summary>
        /// Valid certificates should be configured. The validity of certificates is not checked. Certificates are managed through
        /// /infra/certificates API on Policy.
        /// </summary>
        [JsonProperty(PropertyName = "server_certificates")]
        public IList<string> ServerCertificates { get; set; }
        /// <summary>
        /// Edge clusters configured on MP are auto-discovered by Policy and create corresponding read-only intent objects.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_path", Required = Required.AllowNull)]
        public string EdgeClusterPath { get; set; }
        /// <summary>
        /// Edge nodes should be members of edge cluster configured in edge_cluster_path.
        /// </summary>
        [JsonProperty(PropertyName = "preferred_edge_paths")]
        public IList<string> PreferredEdgePaths { get; set; }
        /// <summary>
        /// The cryptographic protocols listed here are supported by the metadata proxy. TLSv1.1 and TLSv1.2 are supported by
        /// default
        /// </summary>
        [JsonProperty(PropertyName = "crypto_protocols")]
        public IList<string> CryptoProtocols { get; set; }
        /// <summary>
        /// This field is a URL. Example formats - http://1.2.3.4:3888/path, http://text-md-proxy:5001/. Port number should be
        /// between 3000-9000.
        /// </summary>
        [JsonProperty(PropertyName = "server_address", Required = Required.AllowNull)]
        public string ServerAddress { get; set; }
        /// <summary>
        /// Only auto-placed metadata proxies are considered for relocation. Must be FALSE, when the preferred_edge_paths property
        /// is configured.
        /// </summary>
        [JsonProperty(PropertyName = "enable_standby_relocation")]
        public bool? EnableStandbyRelocation { get; set; }
    }
}
