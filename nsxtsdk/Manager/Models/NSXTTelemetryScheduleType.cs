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
    /// Abstract base type for telemetry schedule configuration
    /// </summary>
    [NSXTProperty(Description: @"Abstract base type for telemetry schedule configuration")]
    public class NSXTTelemetryScheduleType 
    {
        /// <summary>
        /// Specify one of DailyTelemetrySchedule, WeeklyTelemetrySchedule, or MonthlyTelemetrySchedule.
        /// </summary>
        [JsonProperty(PropertyName = "frequency_type", Required = Required.AllowNull)]
        public string FrequencyType { get; set; }
    }
}
