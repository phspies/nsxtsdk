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
    /// Execution status of pre/post-upgrade checks
    /// </summary>
    [NSXTProperty(Description: @"Execution status of pre/post-upgrade checks")]
    public class NSXTUpgradeChecksExecutionStatusType 
    {
        /// <summary>
        /// Status of execution of pre/post-upgrade checks
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUpgradeChecksExecutionStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Number of nodes which generated failures or warnings in last execution
        /// of pre/post-upgrade checks. This field has been deprecated. Please use
        /// failure_count instead.
        /// </summary>
        [JsonProperty(PropertyName = "node_with_issues_count")]
        public int? NodeWithIssuesCount { get; set; }
        /// <summary>
        /// Details about current execution of pre/post-upgrade checks
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string? Details { get; set; }
        /// <summary>
        /// Total count of generated failures or warnings in last execution of
        /// pre/post-upgrade checks
        /// </summary>
        [JsonProperty(PropertyName = "failure_count")]
        public int? FailureCount { get; set; }
        /// <summary>
        /// Time (in milliseconds since epoch) when the execution of
        /// pre/post-upgrade checks started
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public long? StartTime { get; set; }
        /// <summary>
        /// Time (in milliseconds since epoch) when the execution of
        /// pre/post-upgrade checks completed
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public long? EndTime { get; set; }
    }
}
