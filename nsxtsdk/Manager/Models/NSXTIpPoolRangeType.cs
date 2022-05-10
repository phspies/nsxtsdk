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
    public class NSXTIpPoolRangeType : NSXTResourceType
    {
        /// <summary>
        /// The start IP Address of the IP Range.
        /// </summary>
        [JsonProperty(PropertyName = "start", Required = Required.AllowNull)]
        public string Start { get; set; }
        /// <summary>
        /// The end IP Address of the IP Range.
        /// </summary>
        [JsonProperty(PropertyName = "end", Required = Required.AllowNull)]
        public string End { get; set; }
    }
}
