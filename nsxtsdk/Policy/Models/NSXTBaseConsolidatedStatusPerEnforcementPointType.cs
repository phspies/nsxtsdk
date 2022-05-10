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
    [JsonConverter(typeof(JsonInheritanceConverter), "resource_type")]
    [JsonInheritanceAttribute("ConsolidatedStatusPerEnforcementPoint", typeof(NSXTConsolidatedStatusPerEnforcementPointType))]
    [NSXTProperty(Description: @"")]
    public class NSXTBaseConsolidatedStatusPerEnforcementPointType : NSXTPolicyRuntimeInfoPerEPType
    {
        /// <summary>
        /// The site where this enforcement point resides.
        /// </summary>
        [JsonProperty(PropertyName = "site_path")]
        public string? SitePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "consolidated_status")]
        public NSXTConsolidatedStatusType ConsolidatedStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        public string ResourceType { get; set; }
        /// <summary>
        /// Enforcement Point Id.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_id")]
        public string? EnforcementPointId { get; set; }
    }
}
