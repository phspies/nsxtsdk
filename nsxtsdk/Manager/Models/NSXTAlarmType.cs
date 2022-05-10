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
    public class NSXTAlarmType : NSXTManagedResourceType
    {
        /// <summary>
        /// Indicates when the corresponding Event instance was last reported in
        /// milliseconds since epoch.
        /// </summary>
        [JsonProperty(PropertyName = "last_reported_time")]
        public long? LastReportedTime { get; set; }
        /// <summary>
        /// Indicate the status which the Alarm is in.
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlarmStatusEnumType Status { get; set; }
        /// <summary>
        /// The entity that the Event instance applies to. Note entity_id may not
        /// be included in a response body. For example, the cpu_high Event may not
        /// return an entity_id.
        /// </summary>
        [JsonProperty(PropertyName = "entity_id")]
        public string? EntityId { get; set; }
        /// <summary>
        /// Name of Event, e.g. manager_cpu_usage_high, certificate_expired.
        /// </summary>
        [JsonProperty(PropertyName = "event_type")]
        public string? EventType { get; set; }
        /// <summary>
        /// Recommended action for Alarm. This is the same action as the
        /// corresponding Event identified by feature_name.event_type.
        /// </summary>
        [JsonProperty(PropertyName = "recommended_action")]
        public string? RecommendedAction { get; set; }
        /// <summary>
        /// The UUID of the node that the Event instance applies to.
        /// </summary>
        [JsonProperty(PropertyName = "node_id")]
        public string? NodeId { get; set; }
        /// <summary>
        /// Feature defining this Event, e.g. manager_health, certificates.
        /// </summary>
        [JsonProperty(PropertyName = "feature_name")]
        public string? FeatureName { get; set; }
        /// <summary>
        /// User ID of the user that set the status value to RESOLVED. This value
        /// can be SYSTEM to indicate that the system resolved the Alarm, for
        /// example when the system determines CPU usage is no longer high and the
        /// cpu_high Alarm is no longer applicable. This property is only returned
        /// when the status value is RESOLVED.
        /// </summary>
        [JsonProperty(PropertyName = "resolved_by")]
        public string? ResolvedBy { get; set; }
        /// <summary>
        /// ID that uniquely identifies an Alarm.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Display name of Event type.
        /// </summary>
        [JsonProperty(PropertyName = "event_type_display_name")]
        public string? EventTypeDisplayName { get; set; }
        /// <summary>
        /// Display name of node that the event instance applies to.
        /// </summary>
        [JsonProperty(PropertyName = "node_display_name")]
        public string? NodeDisplayName { get; set; }
        /// <summary>
        /// Summary description of Alarm. This is the same summary description as the corresponding
        /// Event identified by feature_name.event_type.
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public string? Summary { get; set; }
        /// <summary>
        /// Type of alarm source of the Event instance. Can be one of - INTENT_PATH, ENTITY_ID.
        /// </summary>
        [JsonProperty(PropertyName = "alarm_source_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlarmAlarmSourceTypeEnumType? AlarmSourceType { get; set; }
        /// <summary>
        /// Detailed description of Alarm. This is the same detailed description as the corresponding
        /// Event identified by feature_name.event_type.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// The resource type of node that the Event instance applies to
        /// eg. ClusterNodeConfig, TransportNode.
        /// </summary>
        [JsonProperty(PropertyName = "node_resource_type")]
        public string? NodeResourceType { get; set; }
        /// <summary>
        /// Severity of the Alarm.Can be one of - CRITICAL, HIGH, MEDIUM, LOW.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlarmSeverityEnumType? Severity { get; set; }
        /// <summary>
        /// If alarm_source_type = INTENT_PATH, this field will contain a
        /// list of intent paths for the entity that the event instance applies to.
        /// If alarm_source_type = ENTITY_ID, this field will contain a list with
        /// a single item identifying the entity id that the event instance applies
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "alarm_source")]
        public IList<string> AlarmSource { get; set; }
        /// <summary>
        /// Display name of feature defining this Event.
        /// </summary>
        [JsonProperty(PropertyName = "feature_display_name")]
        public string? FeatureDisplayName { get; set; }
        /// <summary>
        /// User ID of the user that set the status value to SUPPRESSED.
        /// This property is only returned when the status value is SUPPRESSED.
        /// </summary>
        [JsonProperty(PropertyName = "suppressed_by")]
        public string? SuppressedBy { get; set; }
        /// <summary>
        /// Indicates when the Alarm was suppressed in milliseconds since epoch.
        /// This property is only returned when the status value is SUPPRESSED.
        /// </summary>
        [JsonProperty(PropertyName = "suppress_start_time")]
        public long? SuppressStartTime { get; set; }
        /// <summary>
        /// Indicates when the Alarm was resolved in milliseconds since epoch.
        /// This property is only returned when the status value is RESOLVED.
        /// </summary>
        [JsonProperty(PropertyName = "resolved_time")]
        public long? ResolvedTime { get; set; }
        /// <summary>
        /// The entity type that the Event instance applies to.
        /// </summary>
        [JsonProperty(PropertyName = "entity_resource_type")]
        public string? EntityResourceType { get; set; }
        /// <summary>
        /// The time period between suppress_start_time and suppress_start_time +
        /// suppress_duration (specified in hours) an Alarm is SUPPRESSED.
        /// This property is only returned when the status value is SUPPRESSED.
        /// </summary>
        [JsonProperty(PropertyName = "suppress_duration")]
        public long? SuppressDuration { get; set; }
        /// <summary>
        /// Runtime data for Alarm. When an alarming condition occurs, there may
        /// be additional data of interest when triaging the underlying issue, for
        /// example, output from system commands captured at the time of the error.
        /// Note, the contents of this property are not localized.
        /// </summary>
        [JsonProperty(PropertyName = "runtime_data")]
        public string? RuntimeData { get; set; }
        /// <summary>
        /// IP addresses of node that the event instance applies to.
        /// </summary>
        [JsonProperty(PropertyName = "node_ip_addresses")]
        public IList<string> NodeIpAddresses { get; set; }
        /// <summary>
        /// The number of reoccurrences since this alarm has been SUPPRESSED.
        /// </summary>
        [JsonProperty(PropertyName = "reoccurrences_while_suppressed")]
        public long? ReoccurrencesWhileSuppressed { get; set; }
    }
}
