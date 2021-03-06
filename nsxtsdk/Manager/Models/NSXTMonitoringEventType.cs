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
    public class NSXTMonitoringEventType : NSXTManagedResourceType
    {
        /// <summary>
        /// Indicates if the threshold property is configurable via the API.
        /// </summary>
        [JsonProperty(PropertyName = "is_threshold_fixed")]
        public bool? IsThresholdFixed { get; set; }
        /// <summary>
        /// Name of Event, e.g. manager_cpu_usage_high, certificate_expired.
        /// </summary>
        [JsonProperty(PropertyName = "event_type")]
        public string? EventType { get; set; }
        /// <summary>
        /// Maximum allowed threshold value if the threshold is configurable
        /// and a maximum value is applicable.
        /// </summary>
        [JsonProperty(PropertyName = "max_threshold")]
        public long? MaxThreshold { get; set; }
        /// <summary>
        /// Recommended action for the alarm condition.
        /// </summary>
        [JsonProperty(PropertyName = "recommended_action")]
        public string? RecommendedAction { get; set; }
        /// <summary>
        /// Percentage of samples to consider and used in combination with
        /// threshold when determining whether an Event instance status is True or
        /// False. Event evaluation uses sampling to determine Event instance
        /// status. A higher sensitivity value specifies that more samples are used
        /// to ensure accuracy and ignore infrequent or rare spikes in sampled data.
        /// </summary>
        [JsonProperty(PropertyName = "sensitivity", Required = Required.AllowNull)]
        public long Sensitivity { get; set; }
        /// <summary>
        /// Flag to indicate whether sampling for this Event is off or on.
        /// </summary>
        [JsonProperty(PropertyName = "is_disabled")]
        public bool? IsDisabled { get; set; }
        /// <summary>
        /// Feature defining this Event, e.g. manager_health, certificates.
        /// </summary>
        [JsonProperty(PropertyName = "feature_name")]
        public string? FeatureName { get; set; }
        /// <summary>
        /// Threshold to determine if a single sample is True. For example,
        /// if the configured threshold is 95% and the current CPU sample is
        /// 99%, then the current sample is considered True.
        /// Note, if is_threshold_floating_point is true, the threshold_floating_point
        /// property is used to indicate the threshold value.
        /// </summary>
        [JsonProperty(PropertyName = "threshold", Required = Required.AllowNull)]
        public long Threshold { get; set; }
        /// <summary>
        /// Display name of Event type.
        /// </summary>
        [JsonProperty(PropertyName = "event_type_display_name")]
        public string? EventTypeDisplayName { get; set; }
        /// <summary>
        /// Summary description of the event.
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public string? Summary { get; set; }
        /// <summary>
        /// Unique identifier in the form of feature_name.event_type.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Identifies the unit type of the threshold value.
        /// </summary>
        [JsonProperty(PropertyName = "threshold_unit_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMonitoringEventThresholdUnitTypeEnumType? ThresholdUnitType { get; set; }
        /// <summary>
        /// Floating point threshold to determine if a single sample is True.
        /// For example, if the configured threshold is 66.6 percent and the
        /// sample value is 68.8 percent, the current sample is considered
        /// True. Note, if is_threshold_floating_point is false, the threshold
        /// property is used to indicate the threshold value.
        /// </summary>
        [JsonProperty(PropertyName = "threshold_floating_point")]
        public double? ThresholdFloatingPoint { get; set; }
        /// <summary>
        /// Optional field containing OID for SNMP trap sent when
        /// Event instance is False. This value is null if
        /// suppress_snmp_trap or suppress_clear_oid is True.
        /// </summary>
        [JsonProperty(PropertyName = "event_false_snmp_oid")]
        public string? EventFalseSnmpOid { get; set; }
        /// <summary>
        /// Description of Event when an Event instance transitions from True to
        /// False.
        /// </summary>
        [JsonProperty(PropertyName = "description_on_clear")]
        public string? DescriptionOnClear { get; set; }
        /// <summary>
        /// Severity of the Event.Can be one of - CRITICAL, HIGH, MEDIUM, LOW.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMonitoringEventSeverityEnumType? Severity { get; set; }
        /// <summary>
        /// Display name of feature defining this Event.
        /// </summary>
        [JsonProperty(PropertyName = "feature_display_name")]
        public string? FeatureDisplayName { get; set; }
        /// <summary>
        /// Array identifying the nodes on which this Event is applicable.
        /// Can be one or more of the following values - nsx_public_cloud_gateway,
        /// nsx_edge, nsx_esx, nsx_kvm, nsx_manager.
        /// </summary>
        [JsonProperty(PropertyName = "node_types")]
        public IList<string> NodeTypes { get; set; }
        /// <summary>
        /// Minimum allowed threshold value if the threshold is configurable
        /// and a minimum value is applicable.
        /// </summary>
        [JsonProperty(PropertyName = "min_threshold")]
        public long? MinThreshold { get; set; }
        /// <summary>
        /// Detailed description of the event.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Flag to suppress Alarm generation. Alarms are not generated
        /// for this Event when this is set to True.
        /// </summary>
        [JsonProperty(PropertyName = "suppress_alarm")]
        public bool? SuppressAlarm { get; set; }
        /// <summary>
        /// Flag to indicate if the threshold for this Event is a floating point
        /// number. If this value is true, the threshold_floating_point property
        /// is used to indicate the threshold at runtime; otherwise, the threshold
        /// property is used.
        /// </summary>
        [JsonProperty(PropertyName = "is_threshold_floating_point")]
        public bool? IsThresholdFloatingPoint { get; set; }
        /// <summary>
        /// Optional field containing OID for SNMP trap sent when
        /// Event instance is True. This value is null if
        /// suppress_snmp_trap is True.
        /// </summary>
        [JsonProperty(PropertyName = "event_true_snmp_oid")]
        public string? EventTrueSnmpOid { get; set; }
        /// <summary>
        /// Resource Type of entity where this event is applicable
        /// eg. LogicalSwitch, LogicalPort etc.
        /// </summary>
        [JsonProperty(PropertyName = "entity_resource_type")]
        public string? EntityResourceType { get; set; }
        /// <summary>
        /// Flag to suppress SNMP trap generation. SNMP traps are not
        /// sent for this Event when this is set to True.
        /// </summary>
        [JsonProperty(PropertyName = "suppress_snmp_trap")]
        public bool? SuppressSnmpTrap { get; set; }
        /// <summary>
        /// Indicates if the sensitivity property is configurable via the API.
        /// </summary>
        [JsonProperty(PropertyName = "is_sensitivity_fixed")]
        public bool? IsSensitivityFixed { get; set; }
    }
}
