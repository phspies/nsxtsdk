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
    public class NSXTGroupListResultType : NSXTListResultType
    {
        /// <summary>
        /// Group list results
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        public IList<NSXTGroupType> Results { get; set; }
    }
}
