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
    /// Parameters that affect how list results are processed
    /// </summary>
    [NSXTProperty(Description: @"Parameters that affect how list results are processed")]
    public class NSXTListResultQueryParametersType 
    {
        /// <summary>
        /// Comma-separated field names to include in query result
        /// </summary>
        [JsonProperty(PropertyName = "fields")]
        public string? Fields { get; set; }
    }
}
