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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPolicyRealizedResourceType : NSXTPolicyResourceType
    {
        public NSXTPolicyRealizedResourceType()
        {
        }
        /// <summary>
        /// Realization id of this object
        /// </summary>
        [JsonProperty(PropertyName = "realization_specific_identifier")]
        [NSXTProperty(IsRequired: false, Description: @"Realization id of this object")]
        public string? RealizationSpecificIdentifier { get; set; }
        /// <summary>
        /// It defines error code for publish status error.
        /// </summary>
        [JsonProperty(PropertyName = "publish_status_error_code")]
        [NSXTProperty(IsRequired: false, Description: @"It defines error code for publish status error.")]
        public int? PublishStatusErrorCode { get; set; }
        /// <summary>
        /// It defines the root cause for publish status error.
        /// </summary>
        [JsonProperty(PropertyName = "publish_status_error")]
        [NSXTProperty(IsRequired: false, Description: @"It defines the root cause for publish status error.")]
        public string? PublishStatusError { get; set; }
        /// <summary>
        /// It defines the root cause for operational status error.
        /// </summary>
        [JsonProperty(PropertyName = "operational_status_error")]
        [NSXTProperty(IsRequired: false, Description: @"It defines the root cause for operational status error.")]
        public string? OperationalStatusError { get; set; }
        /// <summary>
        /// Possible values could be UP, DOWN, UNKNOWN, FAILURE
        /// This list is not exhaustive.
        /// </summary>
        [JsonProperty(PropertyName = "operational_status")]
        [NSXTProperty(IsRequired: false, Description: @"Possible values could be UP, DOWN, UNKNOWN, FAILUREThis list is not exhaustive.")]
        public string? OperationalStatus { get; set; }
        /// <summary>
        /// Possible values could be UP, DOWN, UNKNOWN, SUCCESS
        /// This list is not exhaustive.
        /// </summary>
        [JsonProperty(PropertyName = "publish_status")]
        [NSXTProperty(IsRequired: false, Description: @"Possible values could be UP, DOWN, UNKNOWN, SUCCESSThis list is not exhaustive.")]
        public string? PublishStatus { get; set; }
        /// <summary>
        /// Desire state paths of this object
        /// </summary>
        [JsonProperty(PropertyName = "intent_reference")]
        [NSXTProperty(IsRequired: false, Description: @"Desire state paths of this object")]
        public IList<string> IntentReference { get; set; }
        /// <summary>
        /// Realization state of this object
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Realization state of this object")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTPolicyRealizedResourceStateEnumType State { get; set; }
        /// <summary>
        /// Realization API of this object on enforcement point
        /// </summary>
        [JsonProperty(PropertyName = "realization_api")]
        [NSXTProperty(IsRequired: false, Description: @"Realization API of this object on enforcement point")]
        public string? RealizationApi { get; set; }
        /// <summary>
        /// Alarm info detail
        /// </summary>
        [JsonProperty(PropertyName = "alarms")]
        [NSXTProperty(IsRequired: false, Description: @"Alarm info detail")]
        public IList<NSXTPolicyAlarmResourceType> Alarms { get; set; }
        /// <summary>
        /// It define the root cause for runtime error.
        /// </summary>
        [JsonProperty(PropertyName = "runtime_error")]
        [NSXTProperty(IsRequired: false, Description: @"It define the root cause for runtime error.")]
        public string? RuntimeError { get; set; }
        /// <summary>
        /// Error details for publish status.
        /// </summary>
        [JsonProperty(PropertyName = "publish_status_error_details")]
        [NSXTProperty(IsRequired: false, Description: @"Error details for publish status.")]
        public IList<NSXTConfigurationStateElementType> PublishStatusErrorDetails { get; set; }
        /// <summary>
        /// Possible values could be UP, DOWN, UNKNOWN, DEGRADED
        /// This list is not exhaustive.
        /// </summary>
        [JsonProperty(PropertyName = "runtime_status")]
        [NSXTProperty(IsRequired: false, Description: @"Possible values could be UP, DOWN, UNKNOWN, DEGRADEDThis list is not exhaustive.")]
        public string? RuntimeStatus { get; set; }
    }
}
