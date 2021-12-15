// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: false, Description: @"Status of execution of pre/post-upgrade checks")]
        public NSXTUpgradeChecksExecutionStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Number of nodes which generated failures or warnings in last execution
        /// of pre/post-upgrade checks
        /// </summary>
        [JsonProperty(PropertyName = "node_with_issues_count")]
        [NSXTProperty(IsRequired: false, Description: @"Number of nodes which generated failures or warnings in last executionof pre/post-upgrade checks")]
        public int? NodeWithIssuesCount { get; set; }
        /// <summary>
        /// Details about current execution of pre/post-upgrade checks
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        [NSXTProperty(IsRequired: false, Description: @"Details about current execution of pre/post-upgrade checks")]
        public string? Details { get; set; }
        /// <summary>
        /// Total count of generated failures or warnings in last execution of
        /// pre/post-upgrade checks
        /// </summary>
        [JsonProperty(PropertyName = "failure_count")]
        [NSXTProperty(IsRequired: false, Description: @"Total count of generated failures or warnings in last execution ofpre/post-upgrade checks")]
        public int? FailureCount { get; set; }
        /// <summary>
        /// Time (in milliseconds since epoch) when the execution of
        /// pre/post-upgrade checks started
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        [NSXTProperty(IsRequired: false, Description: @"Time (in milliseconds since epoch) when the execution ofpre/post-upgrade checks started")]
        public long? StartTime { get; set; }
        /// <summary>
        /// Time (in milliseconds since epoch) when the execution of
        /// pre/post-upgrade checks completed
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        [NSXTProperty(IsRequired: false, Description: @"Time (in milliseconds since epoch) when the execution ofpre/post-upgrade checks completed")]
        public long? EndTime { get; set; }
    }
}