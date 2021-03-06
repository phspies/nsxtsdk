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
    /// Collection of tags used in a policy group for a particular member type
    /// </summary>
    [NSXTProperty(Description: @"Collection of tags used in a policy group for a particular member type")]
    public class NSXTGroupMemberTagsListType 
    {
        /// <summary>
        /// Member type for which we will list the tags
        /// </summary>
        [JsonProperty(PropertyName = "member_type", Required = Required.AllowNull)]
        public string MemberType { get; set; }
        /// <summary>
        /// List of tags for the member type
        /// </summary>
        [JsonProperty(PropertyName = "tags", Required = Required.AllowNull)]
        public IList<string> Tags { get; set; }
    }
}
