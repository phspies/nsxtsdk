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
    public class NSXTLogicalPortMirrorDestinationType : NSXTMirrorDestinationType
    {
        /// <summary>
        /// Destination logical port identifier list.
        /// </summary>
        [JsonProperty(PropertyName = "port_ids", Required = Required.AllowNull)]
        public IList<string> PortIds { get; set; }
    }
}
