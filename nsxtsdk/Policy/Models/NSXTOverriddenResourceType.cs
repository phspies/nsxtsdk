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
    public class NSXTOverriddenResourceType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Site path to the specific site that has overridden the global resource.
        /// </summary>
        [JsonProperty(PropertyName = "site_path")]
        public string? SitePath { get; set; }
        /// <summary>
        /// Policy resource path of the overridden resource.
        /// </summary>
        [JsonProperty(PropertyName = "intent_path")]
        public string? IntentPath { get; set; }
    }
}
