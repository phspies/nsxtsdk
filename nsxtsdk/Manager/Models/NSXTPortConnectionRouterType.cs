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
    public class NSXTPortConnectionRouterType : NSXTPortConnectionEntityType
    {
        /// <summary>
        /// Uplink ports of the Logical Router.
        /// </summary>
        [JsonProperty(PropertyName = "uplink_ports")]
        public IList<NSXTLogicalRouterPortType> UplinkPorts { get; set; }
        /// <summary>
        /// Downlink ports of the Logical Router.
        /// </summary>
        [JsonProperty(PropertyName = "downlink_ports")]
        public IList<NSXTLogicalRouterPortType> DownlinkPorts { get; set; }
    }
}
