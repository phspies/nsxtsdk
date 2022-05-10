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
    public class NSXTSwitchingProfileStatusType 
    {
        /// <summary>
        /// Number of logical ports using a switching profile
        /// </summary>
        [JsonProperty(PropertyName = "num_logical_ports")]
        public long? NumLogicalPorts { get; set; }
        /// <summary>
        /// Identifier for the switching profile
        /// </summary>
        [JsonProperty(PropertyName = "switching_profile_id")]
        public string? SwitchingProfileId { get; set; }
        /// <summary>
        /// Number of logical switches using a switching profile
        /// </summary>
        [JsonProperty(PropertyName = "num_logical_switches")]
        public long? NumLogicalSwitches { get; set; }
    }
}
