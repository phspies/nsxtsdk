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
    /// Advanced load balancer HTTPVersionMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPVersionMatch object")]
    public class NSXTALBHTTPVersionMatchType 
    {
        /// <summary>
        /// HTTP protocol version.
        /// Enum options - ZERO_NINE, ONE_ZERO, ONE_ONE, TWO_ZERO.
        /// Minimum of 1 items required.
        /// Maximum of 8 items allowed.
        /// Allowed in Basic(Allowed values- ONE_ZERO,ONE_ONE) edition,
        /// Essentials(Allowed values- ONE_ZERO,ONE_ONE) edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "versions", Required = Required.AllowNull)]
        public IList<string> Versions { get; set; }
        /// <summary>
        /// Criterion to use for HTTP version matching the version used
        /// in the HTTP request.
        /// Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhttpversionMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
