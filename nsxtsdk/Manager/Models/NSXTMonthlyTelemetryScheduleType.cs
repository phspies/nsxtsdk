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
    public class NSXTMonthlyTelemetryScheduleType : NSXTTelemetryScheduleType
    {
        /// <summary>
        /// Minute at which data will be collected. Specify a value between 0 through 59.
        /// </summary>
        [JsonProperty(PropertyName = "minutes")]
        public long? Minutes { get; set; }
        /// <summary>
        /// Day of month on which data will be collected. Specify a value between 1 through 31.
        /// </summary>
        [JsonProperty(PropertyName = "day_of_month", Required = Required.AllowNull)]
        public long DayOfMonth { get; set; }
        /// <summary>
        /// Hour at which data will be collected. Specify a value between 0 through 23.
        /// </summary>
        [JsonProperty(PropertyName = "hour_of_day", Required = Required.AllowNull)]
        public long HourOfDay { get; set; }
    }
}
