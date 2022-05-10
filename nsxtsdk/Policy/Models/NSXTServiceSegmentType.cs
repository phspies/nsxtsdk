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
    public class NSXTServiceSegmentType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Policy path to transport zone. Only overlay transport zone is supported.
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_path", Required = Required.AllowNull)]
        public string TransportZonePath { get; set; }
        /// <summary>
        /// Policy paths of logical routers or ports | to which this Service Segment can be connected.
        /// </summary>
        [JsonProperty(PropertyName = "lr_paths")]
        public IList<string> LrPaths { get; set; }
    }
}
