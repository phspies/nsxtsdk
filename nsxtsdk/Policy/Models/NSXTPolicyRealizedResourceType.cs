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
    public class NSXTPolicyRealizedResourceType : NSXTPolicyResourceType
    {
        /// <summary>
        /// Realization id of this object
        /// </summary>
        [JsonProperty(PropertyName = "realization_specific_identifier")]
        public string? RealizationSpecificIdentifier { get; set; }
        /// <summary>
        /// It defines error code for publish status error.
        /// </summary>
        [JsonProperty(PropertyName = "publish_status_error_code")]
        public int? PublishStatusErrorCode { get; set; }
        /// <summary>
        /// It defines the root cause for publish status error.
        /// </summary>
        [JsonProperty(PropertyName = "publish_status_error")]
        public string? PublishStatusError { get; set; }
        /// <summary>
        /// It defines the root cause for operational status error.
        /// </summary>
        [JsonProperty(PropertyName = "operational_status_error")]
        public string? OperationalStatusError { get; set; }
        /// <summary>
        /// Possible values could be UP, DOWN, UNKNOWN, FAILURE
        /// This list is not exhaustive.
        /// </summary>
        [JsonProperty(PropertyName = "operational_status")]
        public string? OperationalStatus { get; set; }
        /// <summary>
        /// Possible values could be UP, DOWN, UNKNOWN, SUCCESS
        /// This list is not exhaustive.
        /// </summary>
        [JsonProperty(PropertyName = "publish_status")]
        public string? PublishStatus { get; set; }
        /// <summary>
        /// Desire state paths of this object
        /// </summary>
        [JsonProperty(PropertyName = "intent_reference")]
        public IList<string> IntentReference { get; set; }
        /// <summary>
        /// Realization state of this object
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyRealizedResourceStateEnumType State { get; set; }
        /// <summary>
        /// Realization API of this object on enforcement point
        /// </summary>
        [JsonProperty(PropertyName = "realization_api")]
        public string? RealizationApi { get; set; }
        /// <summary>
        /// Alarm info detail
        /// </summary>
        [JsonProperty(PropertyName = "alarms")]
        public IList<NSXTPolicyAlarmResourceType> Alarms { get; set; }
        /// <summary>
        /// It define the root cause for runtime error.
        /// </summary>
        [JsonProperty(PropertyName = "runtime_error")]
        public string? RuntimeError { get; set; }
        /// <summary>
        /// Error details for publish status.
        /// </summary>
        [JsonProperty(PropertyName = "publish_status_error_details")]
        public IList<NSXTConfigurationStateElementType> PublishStatusErrorDetails { get; set; }
        /// <summary>
        /// Possible values could be UP, DOWN, UNKNOWN, DEGRADED
        /// This list is not exhaustive.
        /// </summary>
        [JsonProperty(PropertyName = "runtime_status")]
        public string? RuntimeStatus { get; set; }
    }
}
