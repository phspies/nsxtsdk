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
    /// A range of MAC addresses with a start and end value
    /// </summary>
    [NSXTProperty(Description: @"A range of MAC addresses with a start and end value")]
    public class NSXTMacRangeType 
    {
        /// <summary>
        /// Start value for MAC address range
        /// </summary>
        [JsonProperty(PropertyName = "start", Required = Required.AllowNull)]
        public string Start { get; set; }
        /// <summary>
        /// End value for MAC address range
        /// </summary>
        [JsonProperty(PropertyName = "end", Required = Required.AllowNull)]
        public string End { get; set; }
    }
}
