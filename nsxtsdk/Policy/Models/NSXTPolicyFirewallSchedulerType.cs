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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPolicyFirewallSchedulerType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// The recurring time interval in a day during which the schedule will be
        /// applicable. It should not be present when the recurring flag is false.
        /// </summary>
        [JsonProperty(PropertyName = "time_interval")]
        [NSXTProperty(IsRequired: false, Description: @"The recurring time interval in a day during which the schedule will beapplicable. It should not be present when the recurring flag is false.")]
        public IList<NSXTPolicyTimeIntervalValueType> TimeInterval { get; set; }
        /// <summary>
        /// If recurring field is set false, then this field must be present. The
        /// schedule will be enforced till the end time of the specified end date.
        /// If recurring field is set true, then this field should not be present.
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        [NSXTProperty(IsRequired: false, Description: @"If recurring field is set false, then this field must be present. Theschedule will be enforced till the end time of the specified end date.If recurring field is set true, then this field should not be present.")]
        public string? EndTime { get; set; }
        /// <summary>
        /// End date on which schedule to end. Example, 12/22/2019.
        /// </summary>
        [JsonProperty(PropertyName = "end_date", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"End date on which schedule to end. Example, 12/22/2019.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string EndDate { get; set; }
        /// <summary>
        /// Host Timezone to be used to enforce firewall rules.
        /// </summary>
        [JsonProperty(PropertyName = "timezone", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Host Timezone to be used to enforce firewall rules.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTPolicyFirewallSchedulerTimezoneEnumType Timezone { get; set; }
        /// <summary>
        /// Time in 24 hour and minutes in multiple of 30. Example, 9:00. If
        /// recurring field is set false, then this field must be present. The
        /// schedule will start getting enforced from the start time of the
        /// specified start date. If recurring field is set true, then this
        /// field should not be present.
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        [NSXTProperty(IsRequired: false, Description: @"Time in 24 hour and minutes in multiple of 30. Example, 9:00. Ifrecurring field is set false, then this field must be present. Theschedule will start getting enforced from the start time of thespecified start date. If recurring field is set true, then thisfield should not be present.")]
        public string? StartTime { get; set; }
        /// <summary>
        /// Flag to indicate whether firewall schedule recurs or not. The default
        /// value is true and it should be set to false when the firewall schedule
        /// does not recur and is a one time time interval.
        /// </summary>
        [JsonProperty(PropertyName = "recurring", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Flag to indicate whether firewall schedule recurs or not. The defaultvalue is true and it should be set to false when the firewall scheduledoes not recur and is a one time time interval.")]
        [System.ComponentModel.DataAnnotations.Required]
        [NSXTDefaultProperty(Default: "")]
        public bool Recurring { get; set; }
        /// <summary>
        /// Days of week on which rules will be enforced. If property is omitted,
        /// then days of the week will not considered while calculating the
        /// firewall schedule. It should not be present when the recurring flag
        /// is false.
        /// </summary>
        [JsonProperty(PropertyName = "days")]
        [NSXTProperty(IsRequired: false, Description: @"Days of week on which rules will be enforced. If property is omitted,then days of the week will not considered while calculating thefirewall schedule. It should not be present when the recurring flagis false.")]
        public IList<string> Days { get; set; }
        /// <summary>
        /// Start date on which schedule to start. Example, 02/22/2019.
        /// </summary>
        [JsonProperty(PropertyName = "start_date", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Start date on which schedule to start. Example, 02/22/2019.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string StartDate { get; set; }
    }
}
