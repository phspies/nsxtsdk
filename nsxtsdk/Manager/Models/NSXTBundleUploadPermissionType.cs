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
    /// Describes whether bundle upload is allowed or not.
    /// </summary>
    [NSXTProperty(Description: @"Describes whether bundle upload is allowed or not.")]
    public class NSXTBundleUploadPermissionType 
    {
        /// <summary>
        /// Reason for not allowing upload.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Flag indication whether upload is allowed or not.
        /// </summary>
        [JsonProperty(PropertyName = "upload_allowed")]
        public bool? UploadAllowed { get; set; }
    }
}
