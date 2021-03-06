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
    /// Collection of tags used in a policy group listed per member type
    /// </summary>
    [NSXTProperty(Description: @"Collection of tags used in a policy group listed per member type")]
    public class NSXTGroupTagsListType 
    {
        /// <summary>
        /// Collection of tags used in a policy group listed per member type
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        public IList<NSXTGroupMemberTagsListType> Results { get; set; }
    }
}
