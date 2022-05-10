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
    /// Parameter to filter overridden resource list by intent path or site path or both.
    /// </summary>
    [NSXTProperty(Description: @"Parameter to filter overridden resource list by intent path or site path or both.")]
    public class NSXTOverrideListRequestParametersType 
    {
        /// <summary>
        /// Site path
        /// </summary>
        [JsonProperty(PropertyName = "site_path")]
        public string? SitePath { get; set; }
        /// <summary>
        /// Global resource path
        /// </summary>
        [JsonProperty(PropertyName = "intent_path")]
        public string? IntentPath { get; set; }
    }
}
