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
    public class NSXTPolicyPktCapResourceType : NSXTPktCapResourceType
    {
        /// <summary>
        /// The path of segment port or router port where the packets are captured
        /// </summary>
        [JsonProperty(PropertyName = "logical_port_path")]
        public string? LogicalPortPath { get; set; }
    }
}
