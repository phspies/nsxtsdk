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
    /// Consolidated Status of an intent object. Status Consolidation of an intent happens at
        /// multiple levels:
        /// - Per Enforcement Point: calculation of the consolidated status is performed using all
        /// realized entities that the intent objet maps to on a specific enforcement point.
        /// - Across Enforcement Points: calculation of the consolidated status is performend
        /// aggregating the consolidated status from each enforcement point.
    /// </summary>
    [NSXTProperty(Description: @"Consolidated Status of an intent object. Status Consolidation of an intent happens atmultiple levels:- Per Enforcement Point: calculation of the consolidated status is performed using allrealized entities that the intent objet maps to on a specific enforcement point.- Across Enforcement Points: calculation of the consolidated status is performendaggregating the consolidated status from each enforcement point.")]
    public class NSXTConsolidatedStatusType 
    {
        /// <summary>
        /// Consolidated Realized Status of an intent object.
        /// </summary>
        [JsonProperty(PropertyName = "consolidated_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTConsolidatedStatusConsolidatedStatusEnumType? ConsolidatedStatus { get; set; }
    }
}
