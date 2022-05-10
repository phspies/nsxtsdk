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
    public class NSXTPortMirroringInstanceType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// If this property is set, the packet will be truncated to the provided
        /// length. If this property is unset, entire packet will be mirrored.
        /// </summary>
        [JsonProperty(PropertyName = "snap_length")]
        public int? SnapLength { get; set; }
        /// <summary>
        /// Port mirroring instance direction
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPortMirroringInstanceDirectionEnumType? Direction { get; set; }
        /// <summary>
        /// Data from source group will be copied to members of
        /// destination group.
        /// </summary>
        [JsonProperty(PropertyName = "destination_group", Required = Required.AllowNull)]
        public string DestinationGroup { get; set; }
    }
}
