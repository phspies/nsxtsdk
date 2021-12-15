// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: true, Description: @"Policy path to transport zone. Only overlay transport zone is supported.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string TransportZonePath { get; set; }
        /// <summary>
        /// Policy paths of logical routers or ports | to which this Service Segment can be connected.
        /// </summary>
        [JsonProperty(PropertyName = "lr_paths")]
        [NSXTProperty(IsRequired: false, Description: @"Policy paths of logical routers or ports | to which this Service Segment can be connected.")]
        public IList<string> LrPaths { get; set; }
    }
}