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
    public class NSXTTelemetryConfigType : NSXTManagedResourceType
    {
        /// <summary>
        /// Deployment id generated during initialization of telemetry config.
        /// </summary>
        [JsonProperty(PropertyName = "telemetry_deployment_id")]
        public string? TelemetryDeploymentId { get; set; }
        /// <summary>
        /// Enable this to schedule data collection and upload times. If enabled,
        /// and a schedule is not provided, a default schedule (WEEKLY, Sunday at 2:00 a.m)
        /// will be applied.
        /// </summary>
        [JsonProperty(PropertyName = "schedule_enabled", Required = Required.AllowNull)]
        public bool ScheduleEnabled { get; set; }
        /// <summary>
        /// Enable this flag to participate in the Customer Experience Improvement Program.
        /// </summary>
        [JsonProperty(PropertyName = "ceip_acceptance", Required = Required.AllowNull)]
        public bool CeipAcceptance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "telemetry_proxy")]
        public NSXTTelemetryProxyType TelemetryProxy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "telemetry_schedule")]
        public NSXTTelemetryScheduleType TelemetrySchedule { get; set; }
        /// <summary>
        /// Enable this flag to specify a proxy, and provide the proxy settings.
        /// </summary>
        [JsonProperty(PropertyName = "proxy_enabled")]
        public bool? ProxyEnabled { get; set; }
    }
}
