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
    public class NSXTGroupMemberTypeListResultType 
    {
        /// <summary>
        /// Collection of member types for the given Group
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Collection of member types for the given Group")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> Results { get; set; }
        /// <summary>
        /// Count of the member types in the results array
        /// </summary>
        [JsonProperty(PropertyName = "result_count")]
        [NSXTProperty(IsRequired: false, Description: @"Count of the member types in the results array")]
        public long? ResultCount { get; set; }
    }
}
