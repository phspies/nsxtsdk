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
    /// Information about the upgrade bundle
    /// </summary>
    [NSXTProperty(Description: @"Information about the upgrade bundle")]
    public class NSXTUpgradeBundleInfoType 
    {
        /// <summary>
        /// URL for uploading upgrade bundle
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// size of upgrade bundle
        /// </summary>
        [JsonProperty(PropertyName = "bundle_size")]
        public string? BundleSize { get; set; }
    }
}
