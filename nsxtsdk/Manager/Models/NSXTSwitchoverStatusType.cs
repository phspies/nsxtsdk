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
    public class NSXTSwitchoverStatusType 
    {
        public NSXTSwitchoverStatusType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "current_step")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTProgressItemType CurrentStep { get; set; }
        /// <summary>
        /// Special messages, most of the time this will be empty, i.e. If SM performing the operation went down, another SM will
        /// restart the progress.
        /// </summary>
        [JsonProperty(PropertyName = "note", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Special messages, most of the time this will be empty, i.e. If SM performing the operation went down, another SM will restart the progress.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Note { get; set; }
        /// <summary>
        /// Status of the operation
        /// </summary>
        [JsonProperty(PropertyName = "overall_status", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Status of the operation")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTSwitchoverStatusOverallStatusEnumType OverallStatus { get; set; }
        /// <summary>
        /// Total number of steps
        /// </summary>
        [JsonProperty(PropertyName = "number_of_steps", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Total number of steps")]
        [System.ComponentModel.DataAnnotations.Required]
        public long NumberOfSteps { get; set; }
        /// <summary>
        /// Current number
        /// </summary>
        [JsonProperty(PropertyName = "current_step_number", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Current number")]
        [System.ComponentModel.DataAnnotations.Required]
        public long CurrentStepNumber { get; set; }
    }
}
