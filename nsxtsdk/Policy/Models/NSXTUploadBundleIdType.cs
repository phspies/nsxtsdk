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
    /// Bundle Id for uploaded file.
    /// </summary>
    [NSXTProperty(Description: @"Bundle Id for uploaded file.")]
    public class NSXTUploadBundleIdType 
    {
        /// <summary>
        /// Bundle id of uploaded file.
        /// </summary>
        [JsonProperty(PropertyName = "bundle_id")]
        public string? BundleId { get; set; }
    }
}
