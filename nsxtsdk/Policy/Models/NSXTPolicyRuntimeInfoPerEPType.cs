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
    /// Runtime Info Per Enforcement Point.
    /// </summary>
    [NSXTProperty(Description: @"Runtime Info Per Enforcement Point.")]
    public class NSXTPolicyRuntimeInfoPerEPType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "alarm")]
        public NSXTPolicyRuntimeAlarmType Alarm { get; set; }
        /// <summary>
        /// Policy Path referencing the enforcement point where the info is fetched.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_path")]
        public string? EnforcementPointPath { get; set; }
    }
}
