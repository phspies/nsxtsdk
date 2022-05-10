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
    public class NSXTNodeIdServicesMapType 
    {
        /// <summary>
        /// List of ServiceTypes.
        /// </summary>
        [JsonProperty(PropertyName = "service_types", Required = Required.AllowNull)]
        public IList<string> ServiceTypes { get; set; }
        /// <summary>
        /// NodeId
        /// </summary>
        [JsonProperty(PropertyName = "node_id", Required = Required.AllowNull)]
        public string NodeId { get; set; }
    }
}
