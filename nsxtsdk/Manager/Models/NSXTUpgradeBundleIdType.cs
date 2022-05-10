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
    /// Identifier of the upgrade bundle
    /// </summary>
    [NSXTProperty(Description: @"Identifier of the upgrade bundle")]
    public class NSXTUpgradeBundleIdType 
    {
        /// <summary>
        /// Identifier of bundle upload
        /// </summary>
        [JsonProperty(PropertyName = "bundle_id")]
        public string? BundleId { get; set; }
    }
}
