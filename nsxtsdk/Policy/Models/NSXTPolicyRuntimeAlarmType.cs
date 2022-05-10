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
    /// Alarm associated with the PolicyRuntimeInfoPerEP that exposes
        /// potential errors when retrieving runtime information from the
        /// enforcement point.
    /// </summary>
    [NSXTProperty(Description: @"Alarm associated with the PolicyRuntimeInfoPerEP that exposespotential errors when retrieving runtime information from theenforcement point.")]
    public class NSXTPolicyRuntimeAlarmType 
    {
        /// <summary>
        /// Alarm error id.
        /// </summary>
        [JsonProperty(PropertyName = "error_id")]
        public string? ErrorId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "error_details")]
        public NSXTPolicyApiErrorType ErrorDetails { get; set; }
        /// <summary>
        /// Error message describing the issue.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
    }
}
