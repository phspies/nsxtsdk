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
    public class NSXTVniPoolType : NSXTManagedResourceType
    {
        /// <summary>
        /// VNI range list results
        /// </summary>
        [JsonProperty(PropertyName = "ranges", Required = Required.AllowNull)]
        public IList<NSXTVniRangeType> Ranges { get; set; }
    }
}
