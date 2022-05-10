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
    public class NSXTDirectoryGroupMemberType : NSXTManagedResourceType
    {
        /// <summary>
        /// Directory group id this group member belongs to
        /// </summary>
        [JsonProperty(PropertyName = "group_id", Required = Required.AllowNull)]
        public string GroupId { get; set; }
        /// <summary>
        /// Directory group name this group member owns
        /// </summary>
        [JsonProperty(PropertyName = "member_group_distinguished_name", Required = Required.AllowNull)]
        public string MemberGroupDistinguishedName { get; set; }
        /// <summary>
        /// Directory group id this group member owns
        /// </summary>
        [JsonProperty(PropertyName = "member_group_id", Required = Required.AllowNull)]
        public string MemberGroupId { get; set; }
        /// <summary>
        /// Directory group distinguished name this group member belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "group_distinguished_name", Required = Required.AllowNull)]
        public string GroupDistinguishedName { get; set; }
        /// <summary>
        /// Whether this member group is a directory member of the parent group speicified by group_id or a nested member group
        /// which parent group is also member group of the parent group speicified by group_id.
        /// </summary>
        [JsonProperty(PropertyName = "nested", Required = Required.AllowNull)]
        public bool Nested { get; set; }
    }
}
