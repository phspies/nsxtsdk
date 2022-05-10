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
    /// Type of issue and detailed description of the issue in case of deployment failure.
    /// </summary>
    [NSXTProperty(Description: @"Type of issue and detailed description of the issue in case of deployment failure.")]
    public class NSXTServiceDeploymentIssueType 
    {
        /// <summary>
        /// Description of issue encountered while service deployment.
        /// </summary>
        [JsonProperty(PropertyName = "issue_description")]
        public string? IssueDescription { get; set; }
        /// <summary>
        /// Timestamp when issue was issue encountered while service deployment.
        /// </summary>
        [JsonProperty(PropertyName = "issue_timestamp")]
        public string? IssueTimestamp { get; set; }
        /// <summary>
        /// Type of issue encountered while service deployment.
        /// </summary>
        [JsonProperty(PropertyName = "issue_type", Required = Required.AllowNull)]
        public string IssueType { get; set; }
    }
}
