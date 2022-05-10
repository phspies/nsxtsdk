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
    /// Restore step info
    /// </summary>
    [NSXTProperty(Description: @"Restore step info")]
    public class NSXTRestoreStepType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public NSXTPerStepRestoreStatusType Status { get; set; }
        /// <summary>
        /// Restore step number
        /// </summary>
        [JsonProperty(PropertyName = "step_number")]
        public long? StepNumber { get; set; }
        /// <summary>
        /// Restore step description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Restore step value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
