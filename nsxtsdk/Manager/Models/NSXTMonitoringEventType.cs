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
        [NSXTProperty(IsRequired: false, Description: @"Indicates if the threshold property is configurable via the API.")]
        public bool? IsThresholdFixed { get; set; }
        /// <summary>
        /// Optional field containing OID for SNMP trap sent when
        /// Event instance is False. This value is null if
        /// suppress_snmp_trap or suppress_clear_oid is True.
        /// </summary>
        [JsonProperty(PropertyName = "event_false_snmp_oid")]
        [NSXTProperty(IsRequired: false, Description: @"Optional field containing OID for SNMP trap sent whenEvent instance is False. This value is null ifsuppress_snmp_trap or suppress_clear_oid is True.")]
        public string? EventFalseSnmpOid { get; set; }
        /// <summary>
        /// Description of Event when an Event instance transitions from True to
        /// False.
        /// </summary>
        [JsonProperty(PropertyName = "description_on_clear")]
        [NSXTProperty(IsRequired: false, Description: @"Description of Event when an Event instance transitions from True toFalse.")]
        public string? DescriptionOnClear { get; set; }
        /// <summary>
        /// Name of Event, e.g. manager_cpu_usage_high, certificate_expired.
        /// </summary>
        [JsonProperty(PropertyName = "event_type")]
        [NSXTProperty(IsRequired: false, Description: @"Name of Event, e.g. manager_cpu_usage_high, certificate_expired.")]
        public string? EventType { get; set; }
        /// <summary>
        /// Recommended action for the alarm condition.
        /// </summary>
        [JsonProperty(PropertyName = "recommended_action")]
        [NSXTProperty(IsRequired: false, Description: @"Recommended action for the alarm condition.")]
        public string? RecommendedAction { get; set; }
        /// <summary>
        /// Severity of the Event.Can be one of - CRITICAL, HIGH, MEDIUM, LOW.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        [NSXTProperty(IsRequired: false, Description: @"Severity of the Event.Can be one of - CRITICAL, HIGH, MEDIUM, LOW.")]
        public NSXTMonitoringEventSeverityEnumType? Severity { get; set; }
        /// <summary>
        /// Percentage of samples to consider and used in combination with
        /// threshold when determining whether an Event instance status is True or
        /// False. Event evaluation uses sampling to determine Event instance
        /// status. A higher sensitivity value specifies that more samples are used
        /// to ensure accuracy and ignore infrequent or rare spikes in sampled data.
        /// </summary>
        [JsonProperty(PropertyName = "sensitivity", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Percentage of samples to consider and used in combination withthreshold when determining whether an Event instance status is True orFalse. Event evaluation uses sampling to determine Event instancestatus. A higher sensitivity value specifies that more samples are usedto ensure accuracy and ignore infrequent or rare spikes in sampled data.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(100)]
        [System.ComponentModel.DataAnnotations.Required]
        public long Sensitivity { get; set; }
        /// <summary>
        /// Flag to indicate whether sampling for this Event is off or on.
        /// </summary>
        [JsonProperty(PropertyName = "is_disabled")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to indicate whether sampling for this Event is off or on.")]
        public bool? IsDisabled { get; set; }
        /// <summary>
        /// Flag to suppress Alarm generation. Alarms are not generated
        /// for this Event when this is set to True.
        /// </summary>
        [JsonProperty(PropertyName = "suppress_alarm")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to suppress Alarm generation. Alarms are not generatedfor this Event when this is set to True.")]
        public bool? SuppressAlarm { get; set; }
        /// <summary>
        /// Summary description of the event.
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        [NSXTProperty(IsRequired: false, Description: @"Summary description of the event.")]
        public string? Summary { get; set; }
        /// <summary>
        /// Display name of feature defining this Event.
        /// </summary>
        [JsonProperty(PropertyName = "feature_display_name")]
        [NSXTProperty(IsRequired: false, Description: @"Display name of feature defining this Event.")]
        public string? FeatureDisplayName { get; set; }
        /// <summary>
        /// Resource Type of entity where this event is applicable
        /// eg. LogicalSwitch, LogicalPort etc.
        /// </summary>
        [JsonProperty(PropertyName = "entity_resource_type")]
        [NSXTProperty(IsRequired: false, Description: @"Resource Type of entity where this event is applicableeg. LogicalSwitch, LogicalPort etc.")]
        public string? EntityResourceType { get; set; }
        /// <summary>
        /// Feature defining this Event, e.g. manager_health, certificates.
        /// </summary>
        [JsonProperty(PropertyName = "feature_name")]
        [NSXTProperty(IsRequired: false, Description: @"Feature defining this Event, e.g. manager_health, certificates.")]
        public string? FeatureName { get; set; }
        /// <summary>
        /// Threshold to determine if a single sample is True. For example,
        /// if the configured threshold is 95% and the current CPU sample is
        /// 99%, then the current sample is considered True.
        /// </summary>
        [JsonProperty(PropertyName = "threshold", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Threshold to determine if a single sample is True. For example,if the configured threshold is 95% and the current CPU sample is99%, then the current sample is considered True.")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Threshold { get; set; }
        /// <summary>
        /// Flag to suppress SNMP trap generation. SNMP traps are not
        /// sent for this Event when this is set to True.
        /// </summary>
        [JsonProperty(PropertyName = "suppress_snmp_trap")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to suppress SNMP trap generation. SNMP traps are notsent for this Event when this is set to True.")]
        public bool? SuppressSnmpTrap { get; set; }
        /// <summary>
        /// Display name of Event type.
        /// </summary>
        [JsonProperty(PropertyName = "event_type_display_name")]
        [NSXTProperty(IsRequired: false, Description: @"Display name of Event type.")]
        public string? EventTypeDisplayName { get; set; }
        /// <summary>
        /// Indicates if the sensitivity property is configurable via the API.
        /// </summary>
        [JsonProperty(PropertyName = "is_sensitivity_fixed")]
        [NSXTProperty(IsRequired: false, Description: @"Indicates if the sensitivity property is configurable via the API.")]
        public bool? IsSensitivityFixed { get; set; }
        /// <summary>
        /// Optional field containing OID for SNMP trap sent when
        /// Event instance is True. This value is null if
        /// suppress_snmp_trap is True.
        /// </summary>
        [JsonProperty(PropertyName = "event_true_snmp_oid")]
        [NSXTProperty(IsRequired: false, Description: @"Optional field containing OID for SNMP trap sent whenEvent instance is True. This value is null ifsuppress_snmp_trap is True.")]
        public string? EventTrueSnmpOid { get; set; }
        /// <summary>
        /// Unique identifier in the form of feature_name.event_type.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        [NSXTProperty(IsRequired: false, Description: @"Unique identifier in the form of feature_name.event_type.")]
        public string? Id { get; set; }
        /// <summary>
        /// Array identifying the nodes on which this Event is applicable.
        /// Can be one or more of the following values - nsx_public_cloud_gateway,
        /// nsx_edge, nsx_esx, nsx_kvm, nsx_manager.
        /// </summary>
        [JsonProperty(PropertyName = "node_types")]
        [NSXTProperty(IsRequired: false, Description: @"Array identifying the nodes on which this Event is applicable.Can be one or more of the following values - nsx_public_cloud_gateway,nsx_edge, nsx_esx, nsx_kvm, nsx_manager.")]
        public IList<string> NodeTypes { get; set; }
        /// <summary>
        /// Detailed description of the event.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        [NSXTProperty(IsRequired: false, Description: @"Detailed description of the event.")]
        public string? Description { get; set; }
    }
}