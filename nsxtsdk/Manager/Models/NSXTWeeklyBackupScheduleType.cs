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
    public class NSXTWeeklyBackupScheduleType : NSXTBackupScheduleType
    {
        public NSXTWeeklyBackupScheduleType()
        {
        }
        /// <summary>
        /// Days of week when backup is taken. 0 - Sunday, 1 - Monday, 2 - Tuesday, 3 - Wednesday ...
        /// </summary>
        [JsonProperty(PropertyName = "days_of_week", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Days of week when backup is taken. 0 - Sunday, 1 - Monday, 2 - Tuesday, 3 - Wednesday ...")]
        [System.ComponentModel.DataAnnotations.Required]
        public long DaysOfWeek { get; set; }
        /// <summary>
        /// Time of day when backup is taken
        /// </summary>
        [JsonProperty(PropertyName = "minute_of_day", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Time of day when backup is taken")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(59)]
        [System.ComponentModel.DataAnnotations.Required]
        public long MinuteOfDay { get; set; }
        /// <summary>
        /// Time of day when backup is taken
        /// </summary>
        [JsonProperty(PropertyName = "hour_of_day", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Time of day when backup is taken")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(23)]
        [System.ComponentModel.DataAnnotations.Required]
        public long HourOfDay { get; set; }
    }
}
