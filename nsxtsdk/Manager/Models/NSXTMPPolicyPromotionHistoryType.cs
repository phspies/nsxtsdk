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
    /// Contain mp to policy promotion history.
    /// </summary>
    [NSXTProperty(Description: @"Contain mp to policy promotion history.")]
    public class NSXTMPPolicyPromotionHistoryType 
    {
        /// <summary>
        /// Represents the type of operation in the mp to policy promotion life cycle. Can be INITIATED, CANCELLED, PARTIAL_SUCCESS 
        /// or SUCCESS.
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMppolicyPromotionHistoryStatusEnumType Status { get; set; }
        /// <summary>
        /// Date and and time of the promotion operation. The date and time is stored in epoch time format.
        /// </summary>
        [JsonProperty(PropertyName = "date_time")]
        public string? DateTime { get; set; }
    }
}
