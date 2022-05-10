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
    public class NSXTUploadBundleStatusType : NSXTUploadBundleRemoteServerType
    {
        /// <summary>
        /// Current state of bundle upload.
        /// UPLOADING - Upload in progress.
        /// DOWNLOADING - Download in progress.
        /// EXTRACTING - Extract in progress.
        /// VERIFYING - Verifying signature of uploaded bundle.
        /// SUCCESS - Upload complete.
        /// FAILED - Upload failed.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUploadBundleStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Upload percentage for bundle.
        /// </summary>
        [JsonProperty(PropertyName = "percent")]
        public double? Percent { get; set; }
        /// <summary>
        /// More detail about bundle upload.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
    }
}
