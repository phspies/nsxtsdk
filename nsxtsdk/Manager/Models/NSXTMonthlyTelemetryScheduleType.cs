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
    public class NSXTMonthlyTelemetryScheduleType : NSXTTelemetryScheduleType
    {
        /// <summary>
        /// Minute at which data will be collected. Specify a value between 0 through 59.
        /// </summary>
        [JsonProperty(PropertyName = "minutes")]
        [NSXTProperty(IsRequired: false, Description: @"Minute at which data will be collected. Specify a value between 0 through 59.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(59)]
        [NSXTDefaultProperty(Default: "")]
        public long? Minutes { get; set; }
        /// <summary>
        /// Day of month on which data will be collected. Specify a value between 1 through 31.
        /// </summary>
        [JsonProperty(PropertyName = "day_of_month", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Day of month on which data will be collected. Specify a value between 1 through 31.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(31)]
        [System.ComponentModel.DataAnnotations.Required]
        public long DayOfMonth { get; set; }
        /// <summary>
        /// Hour at which data will be collected. Specify a value between 0 through 23.
        /// </summary>
        [JsonProperty(PropertyName = "hour_of_day", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Hour at which data will be collected. Specify a value between 0 through 23.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(23)]
        [System.ComponentModel.DataAnnotations.Required]
        public long HourOfDay { get; set; }
    }
}
