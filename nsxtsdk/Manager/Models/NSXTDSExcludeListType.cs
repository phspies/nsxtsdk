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
    public class NSXTDSExcludeListType : NSXTManagedResourceType
    {
        /// <summary>
        /// Total number of members present in Exclude List.
        /// </summary>
        [JsonProperty(PropertyName = "member_count")]
        public long? MemberCount { get; set; }
        /// <summary>
        /// List of members in Exclusion List
        /// </summary>
        [JsonProperty(PropertyName = "members", Required = Required.AllowNull)]
        public IList<NSXTResourceReferenceType> Members { get; set; }
    }
}
