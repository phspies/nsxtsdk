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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIDSEventsBySignatureResultType : NSXTListResultType
    {
        /// <summary>
        /// List of all intrusions detected, grouped by signature. The details include signature id, name, severity, timestamp, and
        /// total number of attempts per signature.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTIDSEventsBySignatureType> Results { get; set; }
    }
}
