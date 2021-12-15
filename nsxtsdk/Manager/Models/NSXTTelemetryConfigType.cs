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
    public class NSXTTelemetryConfigType : NSXTManagedResourceType
    {
        /// <summary>
        /// Enable this to schedule data collection and upload times. If enabled,
        /// and a schedule is not provided, a default schedule (WEEKLY, Sunday at 2:00 a.m)
        /// will be applied.
        /// </summary>
        [JsonProperty(PropertyName = "schedule_enabled", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Enable this to schedule data collection and upload times. If enabled,and a schedule is not provided, a default schedule (WEEKLY, Sunday at 2:00 a.m)will be applied.")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool ScheduleEnabled { get; set; }
        /// <summary>
        /// Specify the proxy configuration (scheme, server, port) here.
        /// </summary>
        [JsonProperty(PropertyName = "telemetry_proxy")]
        [NSXTProperty(IsRequired: false, Description: @"Specify the proxy configuration (scheme, server, port) here.")]
        public NSXTTelemetryProxyType TelemetryProxy { get; set; }
        /// <summary>
        /// Enable this flag to participate in the Customer Experience Improvement Program.
        /// </summary>
        [JsonProperty(PropertyName = "ceip_acceptance", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Enable this flag to participate in the Customer Experience Improvement Program.")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool CeipAcceptance { get; set; }
        /// <summary>
        /// Specify one of Daily, Weekly or Monthly schedules.
        /// </summary>
        [JsonProperty(PropertyName = "telemetry_schedule")]
        [NSXTProperty(IsRequired: false, Description: @"Specify one of Daily, Weekly or Monthly schedules.")]
        public NSXTTelemetryScheduleType TelemetrySchedule { get; set; }
        /// <summary>
        /// Enable this flag to specify a proxy, and provide the proxy settings.
        /// </summary>
        [JsonProperty(PropertyName = "proxy_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Enable this flag to specify a proxy, and provide the proxy settings.")]
        public bool? ProxyEnabled { get; set; }
    }
}