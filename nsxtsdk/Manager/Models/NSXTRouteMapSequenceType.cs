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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTRouteMapSequenceType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "set_criteria")]
        public NSXTRouteMapSequenceSetType SetCriteria { get; set; }
        /// <summary>
        /// Action for the Sequence
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRouteMapSequenceActionEnumType Action { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        public NSXTRouteMapSequenceMatchType MatchCriteria { get; set; }
    }
}
