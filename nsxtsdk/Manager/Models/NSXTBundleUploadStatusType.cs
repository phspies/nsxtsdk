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
    /// Upload status of bundle uploaded from local or remote location.
    /// </summary>
    [NSXTProperty(Description: @"Upload status of bundle uploaded from local or remote location.")]
    public class NSXTBundleUploadStatusType 
    {
        /// <summary>
        /// URL for uploading bundle.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Name of the uploaded bundle.
        /// </summary>
        [JsonProperty(PropertyName = "bundle_name")]
        public string? BundleName { get; set; }
        /// <summary>
        /// Detailed status of bundle upload.
        /// </summary>
        [JsonProperty(PropertyName = "detailed_status")]
        public string? DetailedStatus { get; set; }
        /// <summary>
        /// Percent of bundle uploaded from remote location.
        /// </summary>
        [JsonProperty(PropertyName = "percent")]
        public double? Percent { get; set; }
        /// <summary>
        /// Current status of bundle upload.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBundleUploadStatusStatusEnumType? Status { get; set; }
    }
}
