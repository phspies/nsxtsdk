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
    public class NSXTMetadataProxyType : NSXTManagedResourceType
    {
        /// <summary>
        /// secret to access metadata server
        /// </summary>
        [JsonProperty(PropertyName = "secret")]
        public string? Secret { get; set; }
        /// <summary>
        /// The CAs referenced here must be uploaded to the truststore using the API
        /// POST /api/v1/trust-management/certificates?action=import.
        /// User needs to ensure a correct CA for this metedata server is used. The REST API can
        /// not detect a wrong CA which was used to verify a different server. If the Metadata
        /// Proxy reports an ERROR or NO_BACKUP status, user can check the metadata proxy log
        /// at transport node for a possible CA issue.
        /// </summary>
        [JsonProperty(PropertyName = "metadata_server_ca_ids")]
        public IList<string> MetadataServerCaIds { get; set; }
        /// <summary>
        /// If none is provided, the NSX will auto-select two edge-nodes from the given edge cluster.
        /// If user provides only one edge node, there will be no HA support.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_member_indexes")]
        public long? EdgeClusterMemberIndexes { get; set; }
        /// <summary>
        /// The cryptographic protocols listed here are supported by the metadata proxy.
        /// The TLSv1.1 and TLSv1.2 are supported by default.
        /// </summary>
        [JsonProperty(PropertyName = "crypto_protocols")]
        public IList<string> CryptoProtocols { get; set; }
        /// <summary>
        /// The URL in format scheme://host:port/path. Please note, the scheme supports only http
        /// and https as of now, port supports range 3000 - 9000, inclusive.
        /// </summary>
        [JsonProperty(PropertyName = "metadata_server_url", Required = Required.AllowNull)]
        public string MetadataServerUrl { get; set; }
        /// <summary>
        /// id of attached logical port
        /// </summary>
        [JsonProperty(PropertyName = "attached_logical_port_id")]
        public string? AttachedLogicalPortId { get; set; }
        /// <summary>
        /// Flag to enable the auto-relocation of standby Metadata Proxy in
        /// case of edge node failure. Only tier 1 and auto placed Metadata
        /// Proxy are considered for the relocation.
        /// </summary>
        [JsonProperty(PropertyName = "enable_standby_relocation")]
        public bool? EnableStandbyRelocation { get; set; }
        /// <summary>
        /// edge cluster uuid
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_id", Required = Required.AllowNull)]
        public string EdgeClusterId { get; set; }
    }
}
