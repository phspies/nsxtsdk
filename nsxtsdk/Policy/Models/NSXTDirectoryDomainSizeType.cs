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
    /// Size of Directory Domain
    /// </summary>
    [NSXTProperty(Description: @"Size of Directory Domain")]
    public class NSXTDirectoryDomainSizeType 
    {
        /// <summary>
        /// Number of groups
        /// </summary>
        [JsonProperty(PropertyName = "group_count")]
        public int? GroupCount { get; set; }
        /// <summary>
        /// Number of users
        /// </summary>
        [JsonProperty(PropertyName = "user_count")]
        public int? UserCount { get; set; }
        /// <summary>
        /// Number of group members
        /// </summary>
        [JsonProperty(PropertyName = "group_member_count")]
        public int? GroupMemberCount { get; set; }
    }
}
