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
    /// Time interval on which firewall schedule will be applicable
    /// </summary>
    [NSXTProperty(Description: @"Time interval on which firewall schedule will be applicable")]
    public class NSXTPolicyTimeIntervalValueType 
    {
        /// <summary>
        /// Time in 24 hour and minutes in multiple of 30. Example, 9:00.
        /// </summary>
        [JsonProperty(PropertyName = "start_interval", Required = Required.AllowNull)]
        public string StartInterval { get; set; }
        /// <summary>
        /// Time in 24 hour and minutes in multiple of 30. Example, 17:30.
        /// </summary>
        [JsonProperty(PropertyName = "end_interval", Required = Required.AllowNull)]
        public string EndInterval { get; set; }
    }
}
