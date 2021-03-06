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
    public class NSXTVniRangeType : NSXTResourceType
    {
        /// <summary>
        /// Start value for vni range to be used for virtual networks
        /// </summary>
        [JsonProperty(PropertyName = "start", Required = Required.AllowNull)]
        public long Start { get; set; }
        /// <summary>
        /// End value for vni range to be used for virtual networks
        /// </summary>
        [JsonProperty(PropertyName = "end", Required = Required.AllowNull)]
        public long End { get; set; }
    }
}
