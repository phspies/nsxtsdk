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
    public class NSXTPolicyIdsEventsBySignatureResultType : NSXTListResultType
    {
        /// <summary>
        /// List of all intrusions detected, grouped by signature. The details include signature id, name, severity, timestamp, and
        /// total number of attempts per signature.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTPolicyIdsEventsBySignatureType> Results { get; set; }
    }
}
