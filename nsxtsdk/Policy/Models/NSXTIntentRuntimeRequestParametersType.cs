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
    /// Request parameters that represents a an intent path.
    /// </summary>
    [NSXTProperty(Description: @"Request parameters that represents a an intent path.")]
    public class NSXTIntentRuntimeRequestParametersType 
    {
        /// <summary>
        /// Policy Path referencing a site. This is applicable only on a GlobalManager. If no
        /// site_path is specified, then based on the span of the intent the response will be
        /// fetched from the respective sites
        /// </summary>
        [JsonProperty(PropertyName = "site_path")]
        public string? SitePath { get; set; }
        /// <summary>
        /// Policy Path referencing an intent object.
        /// </summary>
        [JsonProperty(PropertyName = "intent_path", Required = Required.AllowNull)]
        public string IntentPath { get; set; }
    }
}
