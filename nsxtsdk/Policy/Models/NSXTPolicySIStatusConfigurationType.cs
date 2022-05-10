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
    public class NSXTPolicySIStatusConfigurationType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// If set to true, service insertion for east-west traffic is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "east_west_enabled")]
        public bool? EastWestEnabled { get; set; }
        /// <summary>
        /// If set to true, service insertion for north-south traffic is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "north_south_enabled")]
        public bool? NorthSouthEnabled { get; set; }
    }
}
