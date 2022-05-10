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
    /// Upload status of upgrade bundle uploaded from url
    /// </summary>
    [NSXTProperty(Description: @"Upload status of upgrade bundle uploaded from url")]
    public class NSXTUpgradeBundleUploadStatusType 
    {
        /// <summary>
        /// URL for uploading upgrade bundle
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Current status of upgrade bundle upload
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUpgradeBundleUploadStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Detailed status of upgrade bundle upload
        /// </summary>
        [JsonProperty(PropertyName = "detailed_status")]
        public string? DetailedStatus { get; set; }
        /// <summary>
        /// Percent of bundle uploaded from URL
        /// </summary>
        [JsonProperty(PropertyName = "percent")]
        public double? Percent { get; set; }
    }
}
