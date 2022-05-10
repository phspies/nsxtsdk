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
    public class NSXTMigrationFeedbackSummaryListResultType : NSXTListResultType
    {
        /// <summary>
        /// Feedback resolution job status
        /// </summary>
        [JsonProperty(PropertyName = "feedback_resolution_job_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMigrationFeedbackSummaryListResultFeedbackResolutionJobStatusEnumType? FeedbackResolutionJobStatus { get; set; }
        /// <summary>
        /// Paged Collection of feedback categories
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        public IList<NSXTMigrationFeedbackCategoryType> Results { get; set; }
    }
}
