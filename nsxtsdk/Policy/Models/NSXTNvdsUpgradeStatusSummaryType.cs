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
    /// Overall status of the upgrade readiness check
    /// </summary>
    [NSXTProperty(Description: @"Overall status of the upgrade readiness check")]
    public class NSXTNvdsUpgradeStatusSummaryType 
    {
        /// <summary>
        /// Tracking ID of nvds upgrade precheck
        /// </summary>
        [JsonProperty(PropertyName = "precheck_id")]
        public string? PrecheckId { get; set; }
        /// <summary>
        /// Overall state of migration across all TransportNodes
        /// </summary>
        [JsonProperty(PropertyName = "migration_state")]
        public IList<NSXTNvdsUpgradeHostStateType> MigrationState { get; set; }
        /// <summary>
        /// Config issue in pre-check
        /// </summary>
        [JsonProperty(PropertyName = "precheck_issue")]
        public IList<NSXTNvdsUpgradeConfigIssueType> PrecheckIssue { get; set; }
        /// <summary>
        /// Overall status of pre-check
        /// </summary>
        [JsonProperty(PropertyName = "precheck_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNvdsUpgradeStatusSummaryPrecheckStatusEnumType? PrecheckStatus { get; set; }
    }
}
