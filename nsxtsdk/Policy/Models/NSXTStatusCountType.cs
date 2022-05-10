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
    public class NSXTStatusCountType 
    {
        /// <summary>
        /// Roll-up status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTStatusCountStatusEnumType? Status { get; set; }
        /// <summary>
        /// Degraded count
        /// </summary>
        [JsonProperty(PropertyName = "degraded_count")]
        public int? DegradedCount { get; set; }
        /// <summary>
        /// Down count
        /// </summary>
        [JsonProperty(PropertyName = "down_count")]
        public int? DownCount { get; set; }
        /// <summary>
        /// Up count
        /// </summary>
        [JsonProperty(PropertyName = "up_count")]
        public int? UpCount { get; set; }
    }
}
