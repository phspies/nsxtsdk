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
    /// Port Connection Containers Entities
    /// </summary>
    [NSXTProperty(Description: @"Port Connection Containers Entities")]
    public class NSXTPortConnectionContainersEntitiesType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "logical_ports")]
        public IList<NSXTLogicalPortType> LogicalPorts { get; set; }
    }
}
