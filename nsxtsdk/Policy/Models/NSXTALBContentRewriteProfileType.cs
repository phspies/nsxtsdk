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
    /// Advanced load balancer ContentRewriteProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer ContentRewriteProfile object")]
    public class NSXTALBContentRewriteProfileType 
    {
        /// <summary>
        /// Enable rewrite on response body.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "response_rewrite_enabled")]
        public bool? ResponseRewriteEnabled { get; set; }
        /// <summary>
        /// Rewrite only content types listed in this string group.
        /// Content types not present in this list are not rewritten.
        /// It is a reference to an object of type StringGroup.
        /// </summary>
        [JsonProperty(PropertyName = "rewritable_content_path")]
        public string? RewritableContentPath { get; set; }
        /// <summary>
        /// Strings to be matched and replaced with on the response
        /// body.
        /// This should be configured when response_rewrite_enabled is
        /// set to true.
        /// </summary>
        [JsonProperty(PropertyName = "rsp_match_replace_pair")]
        public IList<NSXTALBMatchReplacePairType> RspMatchReplacePair { get; set; }
    }
}
