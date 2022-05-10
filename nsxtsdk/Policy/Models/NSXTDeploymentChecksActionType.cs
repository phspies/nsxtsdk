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
    /// Pre/Post deployment check.
    /// </summary>
    [NSXTProperty(Description: @"Pre/Post deployment check.")]
    public class NSXTDeploymentChecksActionType 
    {
        /// <summary>
        /// Run pre/post deployment checks.
        /// PRE_CHECKS - Run pre-check before deployment.
        /// POST_CHECKS - Run post-check after deployment.
        /// ABORT_CHECKS - Abort running pre/post deployement checks.
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDeploymentChecksActionActionEnumType Action { get; set; }
    }
}
