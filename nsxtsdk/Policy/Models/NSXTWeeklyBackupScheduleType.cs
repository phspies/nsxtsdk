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
    public class NSXTWeeklyBackupScheduleType : NSXTBackupScheduleType
    {
        /// <summary>
        /// Days of week when backup is taken. 0 - Sunday, 1 - Monday, 2 - Tuesday, 3 - Wednesday ...
        /// </summary>
        [JsonProperty(PropertyName = "days_of_week", Required = Required.AllowNull)]
        public long DaysOfWeek { get; set; }
        /// <summary>
        /// Time of day when backup is taken
        /// </summary>
        [JsonProperty(PropertyName = "minute_of_day", Required = Required.AllowNull)]
        public long MinuteOfDay { get; set; }
        /// <summary>
        /// Time of day when backup is taken
        /// </summary>
        [JsonProperty(PropertyName = "hour_of_day", Required = Required.AllowNull)]
        public long HourOfDay { get; set; }
    }
}
