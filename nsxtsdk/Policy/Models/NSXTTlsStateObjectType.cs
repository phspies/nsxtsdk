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
    public class NSXTTlsStateObjectType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Tier-0/Tier-1 Logical Router policy path
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string? Scope { get; set; }
        /// <summary>
        /// Fully Qualified Domain Name.
        /// </summary>
        [JsonProperty(PropertyName = "fqdn", Required = Required.AllowNull)]
        public string Fqdn { get; set; }
        /// <summary>
        /// TLS inspection bypass action.
        /// </summary>
        [JsonProperty(PropertyName = "inspection_action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTlsStateObjectInspectionActionEnumType? InspectionAction { get; set; }
        /// <summary>
        /// TLS inspection failure reasons.
        /// </summary>
        [JsonProperty(PropertyName = "failure_reasons")]
        public IList<string> FailureReasons { get; set; }
    }
}
