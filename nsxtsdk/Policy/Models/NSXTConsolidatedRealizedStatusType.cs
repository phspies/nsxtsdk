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
    public class NSXTConsolidatedRealizedStatusType : NSXTAggregatePolicyRuntimeInfoType
    {
        /// <summary>
        /// Represent highest intent version across all realized objects
        /// </summary>
        [JsonProperty(PropertyName = "intent_version")]
        public string? IntentVersion { get; set; }
        /// <summary>
        /// Aggregated Realization state of this object
        /// </summary>
        [JsonProperty(PropertyName = "publish_status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTConsolidatedRealizedStatusPublishStatusEnumType PublishStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "consolidated_status")]
        public NSXTConsolidatedStatusType ConsolidatedStatus { get; set; }
        /// <summary>
        /// List of Consolidated Realized Status per enforcement point.
        /// </summary>
        [JsonProperty(PropertyName = "consolidated_status_per_enforcement_point")]
        public IList<NSXTConsolidatedStatusPerEnforcementPointType> ConsolidatedStatusPerEnforcementPoint { get; set; }
    }
}
