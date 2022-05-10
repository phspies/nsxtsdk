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
    public class NSXTRouteMapType : NSXTManagedResourceType
    {
        /// <summary>
        /// Logical router id
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id")]
        public string? LogicalRouterId { get; set; }
        /// <summary>
        /// Ordered list of routeMap sequences
        /// </summary>
        [JsonProperty(PropertyName = "sequences", Required = Required.AllowNull)]
        public IList<NSXTRouteMapSequenceType> Sequences { get; set; }
    }
}
