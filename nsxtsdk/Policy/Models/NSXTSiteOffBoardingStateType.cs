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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSiteOffBoardingStateType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Represents site offboarding status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSiteOffBoardingStateStatusEnumType? Status { get; set; }
        /// <summary>
        /// Captures message associated with status.
        /// If FAILED, can contain folowing errors
        /// local site configuration is null
        /// internal server error with detail
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
        /// <summary>
        /// Contains previus failed message in case,
        /// state machine is stuck in a state
        /// </summary>
        [JsonProperty(PropertyName = "previousErrorMessage")]
        public string? PreviousErrorMessage { get; set; }
    }
}
