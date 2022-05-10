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
    /// Aggregate of PolicyRuntimeInfoPerEP across Enforcement Points.
    /// </summary>
    [NSXTProperty(Description: @"Aggregate of PolicyRuntimeInfoPerEP across Enforcement Points.")]
    public class NSXTAggregatePolicyRuntimeInfoType 
    {
        /// <summary>
        /// Intent path of object, forward slashes must be escaped using %2F.
        /// </summary>
        [JsonProperty(PropertyName = "intent_path")]
        public string? IntentPath { get; set; }
    }
}
