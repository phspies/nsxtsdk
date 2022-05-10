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
    /// Describes a config item for System Health profile.
    /// </summary>
    [NSXTProperty(Description: @"Describes a config item for System Health profile.")]
    public class NSXTSHAPredefinedPluginProfileDataType 
    {
        /// <summary>
        /// The interval of plugin to report the status.
        /// </summary>
        [JsonProperty(PropertyName = "report_interval")]
        public long? ReportInterval { get; set; }
        /// <summary>
        /// The interval of plugin to check the status.
        /// </summary>
        [JsonProperty(PropertyName = "check_interval")]
        public long? CheckInterval { get; set; }
        /// <summary>
        /// The smallest report interval if the status is changed.
        /// The value of smallest_report_interval_if_change should be
        /// less than the value of report_interval
        /// </summary>
        [JsonProperty(PropertyName = "smallest_report_interval_if_change")]
        public long? SmallestReportIntervalIfChange { get; set; }
    }
}
