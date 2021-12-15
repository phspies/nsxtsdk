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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTMigrationFeedbackSummaryListResultType : NSXTListResultType
    {
        /// <summary>
        /// Feedback resolution job status
        /// </summary>
        [JsonProperty(PropertyName = "feedback_resolution_job_status")]
        [NSXTProperty(IsRequired: false, Description: @"Feedback resolution job status")]
        public NSXTMigrationFeedbackSummaryListResultFeedbackResolutionJobStatusEnumType? FeedbackResolutionJobStatus { get; set; }
        /// <summary>
        /// Paged Collection of feedback categories
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Paged Collection of feedback categories")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTMigrationFeedbackCategoryType> Results { get; set; }
    }
}