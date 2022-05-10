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
    public class NSXTIdsSignatureStatusType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// READY means signatures were downloaded and parsed successfully.
        /// PENDING means that signatures download is in progress.
        /// ERROR means error occurred during signature processing.
        /// DISABLED means IDS is disabled.
        /// </summary>
        [JsonProperty(PropertyName = "download_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIdsSignatureStatusDownloadStatusEnumType? DownloadStatus { get; set; }
        /// <summary>
        /// AVAILABLE means the signatures are available for the version.
        /// UNAVAILABLE means there are no available signatures for the version.
        /// </summary>
        [JsonProperty(PropertyName = "signature_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIdsSignatureStatusSignatureStatusEnumType? SignatureStatus { get; set; }
        /// <summary>
        /// Represents the version id.
        /// </summary>
        [JsonProperty(PropertyName = "version_id")]
        public string? VersionId { get; set; }
    }
}
