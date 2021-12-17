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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Advanced load balancer HTTPStatusMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPStatusMatch object")]
    public class NSXTALBHTTPStatusMatchType 
    {
        public NSXTALBHTTPStatusMatchType()
        {
        }
        /// <summary>
        /// HTTP response status code range(s).
        /// </summary>
        [JsonProperty(PropertyName = "ranges")]
        [NSXTProperty(IsRequired: false, Description: @"HTTP response status code range(s).")]
        public IList<NSXTALBHTTPStatusRangeType> Ranges { get; set; }
        /// <summary>
        /// HTTP response status code(s).
        /// </summary>
        [JsonProperty(PropertyName = "status_codes")]
        [NSXTProperty(IsRequired: false, Description: @"HTTP response status code(s).")]
        public long? StatusCodes { get; set; }
        /// <summary>
        /// Criterion to use for matching the HTTP response status
        /// code(s).
        /// Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Criterion to use for matching the HTTP response statuscode(s).Enum options - IS_IN, IS_NOT_IN.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTAlbhttpstatusMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
