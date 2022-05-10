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
    /// List of NSGroupExpressions
    /// </summary>
    [NSXTProperty(Description: @"List of NSGroupExpressions")]
    public class NSXTNSGroupExpressionListType 
    {
        /// <summary>
        /// List of NSGroupExpressions to be passed to add and remove APIs
        /// </summary>
        [JsonProperty(PropertyName = "members", Required = Required.AllowNull)]
        public IList<NSXTNSGroupExpressionType> Members { get; set; }
    }
}
