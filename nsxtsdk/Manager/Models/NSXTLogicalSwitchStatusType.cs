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
    public class NSXTLogicalSwitchStatusType 
    {
        /// <summary>
        /// Count of Logical Ports belonging to this switch
        /// </summary>
        [JsonProperty(PropertyName = "num_logical_ports")]
        public int? NumLogicalPorts { get; set; }
        /// <summary>
        /// Unique ID identifying the the Logical Switch
        /// </summary>
        [JsonProperty(PropertyName = "logical_switch_id")]
        public string? LogicalSwitchId { get; set; }
    }
}
