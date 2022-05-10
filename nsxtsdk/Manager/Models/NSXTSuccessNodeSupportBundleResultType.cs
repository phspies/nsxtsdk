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
    public class NSXTSuccessNodeSupportBundleResultType 
    {
        /// <summary>
        /// Name of support bundle, e.g. nsx_NODETYPE_UUID_YYYYMMDD_HHMMSS.tgz
        /// </summary>
        [JsonProperty(PropertyName = "bundle_name")]
        public string? BundleName { get; set; }
        /// <summary>
        /// Display name of node
        /// </summary>
        [JsonProperty(PropertyName = "node_display_name")]
        public string? NodeDisplayName { get; set; }
        /// <summary>
        /// UUID of node
        /// </summary>
        [JsonProperty(PropertyName = "node_id")]
        public string? NodeId { get; set; }
        /// <summary>
        /// File's SHA256 thumbprint
        /// </summary>
        [JsonProperty(PropertyName = "sha256_thumbprint")]
        public string? Sha256Thumbprint { get; set; }
        /// <summary>
        /// Size of support bundle in bytes
        /// </summary>
        [JsonProperty(PropertyName = "bundle_size")]
        public long? BundleSize { get; set; }
    }
}
