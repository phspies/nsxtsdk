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
    /// Advanced load balancer MicroServiceMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer MicroServiceMatch object")]
    public class NSXTALBMicroServiceMatchType 
    {
        /// <summary>
        /// Criterion to use for Micro Service matching the HTTP
        /// request.
        /// Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbmicroServiceMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
