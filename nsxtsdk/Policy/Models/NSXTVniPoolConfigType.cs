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
    public class NSXTVniPoolConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Start value of VNI Pool range
        /// </summary>
        [JsonProperty(PropertyName = "start", Required = Required.AllowNull)]
        public int Start { get; set; }
        /// <summary>
        /// End value of VNI Pool range
        /// </summary>
        [JsonProperty(PropertyName = "end", Required = Required.AllowNull)]
        public int End { get; set; }
    }
}
