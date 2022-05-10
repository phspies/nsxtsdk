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
    public class NSXTSwitchoverStatusType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "current_step")]
        public NSXTProgressItemType CurrentStep { get; set; }
        /// <summary>
        /// Special messages, most of the time this will be empty, i.e. If SM performing the operation went down, another SM will
        /// restart the progress.
        /// </summary>
        [JsonProperty(PropertyName = "note", Required = Required.AllowNull)]
        public string Note { get; set; }
        /// <summary>
        /// Status of the operation
        /// </summary>
        [JsonProperty(PropertyName = "overall_status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSwitchoverStatusOverallStatusEnumType OverallStatus { get; set; }
        /// <summary>
        /// Total number of steps
        /// </summary>
        [JsonProperty(PropertyName = "number_of_steps", Required = Required.AllowNull)]
        public long NumberOfSteps { get; set; }
        /// <summary>
        /// Current number
        /// </summary>
        [JsonProperty(PropertyName = "current_step_number", Required = Required.AllowNull)]
        public long CurrentStepNumber { get; set; }
    }
}
