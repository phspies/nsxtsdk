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
    public class NSXTPolicyTaskType : NSXTTaskPropertiesType
    {
        /// <summary>
        /// This property holds the reason of the task failure, if any.
        /// </summary>
        [JsonProperty(PropertyName = "failure_msg")]
        public string? FailureMsg { get; set; }
    }
}
