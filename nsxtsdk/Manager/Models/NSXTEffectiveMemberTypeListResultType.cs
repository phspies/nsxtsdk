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
    public class NSXTEffectiveMemberTypeListResultType 
    {
        /// <summary>
        /// Collection of member types for the given NSGroup
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        public IList<string> Results { get; set; }
        /// <summary>
        /// Count of the member types in the results array
        /// </summary>
        [JsonProperty(PropertyName = "result_count")]
        public long? ResultCount { get; set; }
    }
}
