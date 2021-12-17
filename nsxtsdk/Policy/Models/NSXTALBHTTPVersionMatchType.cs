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
    /// Advanced load balancer HTTPVersionMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPVersionMatch object")]
    public class NSXTALBHTTPVersionMatchType 
    {
        public NSXTALBHTTPVersionMatchType()
        {
        }
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
        [NSXTProperty(IsRequired: true, Description: @"HTTP protocol version.Enum options - ZERO_NINE, ONE_ZERO, ONE_ONE, TWO_ZERO.Minimum of 1 items required.Maximum of 8 items allowed.Allowed in Basic(Allowed values- ONE_ZERO,ONE_ONE) edition,Essentials(Allowed values- ONE_ZERO,ONE_ONE) edition,Enterprise edition.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> Versions { get; set; }
        /// <summary>
        /// Criterion to use for HTTP version matching the version used
        /// in the HTTP request.
        /// Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Criterion to use for HTTP version matching the version usedin the HTTP request.Enum options - IS_IN, IS_NOT_IN.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTAlbhttpversionMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
