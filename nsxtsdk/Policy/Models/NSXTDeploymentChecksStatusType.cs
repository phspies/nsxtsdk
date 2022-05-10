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
    /// Pre/Post deployment status.
    /// </summary>
    [NSXTProperty(Description: @"Pre/Post deployment status.")]
    public class NSXTDeploymentChecksStatusType 
    {
        /// <summary>
        /// Status pre/post check.
        /// SUCCESS - Successfully completed pre/post check.
        /// FAILED - Failed pre/post check.
        /// WARNING - Warning in pre/post check.
        /// SKIPPED - Pre/post check skipped.
        /// IN_PROGRESS - Pre/post check in progress.
        /// STOPPING - Stopping pre/post check.
        /// STOPPED - Pre/post check stopped.
        /// NOT_STARTED - Pre/post check not started
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDeploymentChecksStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Reason for failure of pre/post check.
        /// Otherwise empty.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Name of pre/post check.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Show more information about pre/post check performed.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
    }
}
