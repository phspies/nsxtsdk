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
    /// Advanced load balancer HTTPStatusMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPStatusMatch object")]
    public class NSXTALBHTTPStatusMatchType 
    {
        /// <summary>
        /// HTTP response status code range(s).
        /// </summary>
        [JsonProperty(PropertyName = "ranges")]
        public IList<NSXTALBHTTPStatusRangeType> Ranges { get; set; }
        /// <summary>
        /// HTTP response status code(s).
        /// </summary>
        [JsonProperty(PropertyName = "status_codes")]
        public long? StatusCodes { get; set; }
        /// <summary>
        /// Criterion to use for matching the HTTP response status
        /// code(s).
        /// Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhttpstatusMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
