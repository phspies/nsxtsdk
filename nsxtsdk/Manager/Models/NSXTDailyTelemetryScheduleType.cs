// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDailyTelemetryScheduleType : NSXTTelemetryScheduleType
    {
        /// <summary>
        /// Minute at which data will be collected. Specify a value between 0 through 59.
        /// </summary>
        public long? Minutes { get; set; }
        /// <summary>
        /// Hour at which data will be collected. Specify a value between 0 through 23.
        /// </summary>
        [JsonProperty(PropertyName = "hour_of_day", Required = Required.AllowNull)]
        public long HourOfDay { get; set; }
    }
}
