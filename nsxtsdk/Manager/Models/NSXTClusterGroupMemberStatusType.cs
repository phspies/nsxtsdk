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
    /// This type contains the attributes and status of a group member.
    /// </summary>
    [NSXTProperty(Description: @"This type contains the attributes and status of a group member.")]
    public class NSXTClusterGroupMemberStatusType 
    {
        /// <summary>
        /// IP of the group member
        /// </summary>
        [JsonProperty(PropertyName = "member_ip")]
        public string? MemberIp { get; set; }
        /// <summary>
        /// FQDN of the group member
        /// </summary>
        [JsonProperty(PropertyName = "member_fqdn")]
        public string? MemberFqdn { get; set; }
        /// <summary>
        /// Status of the group member
        /// </summary>
        [JsonProperty(PropertyName = "member_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTClusterGroupMemberStatusMemberStatusEnumType? MemberStatus { get; set; }
        /// <summary>
        /// UUID of the group member
        /// </summary>
        [JsonProperty(PropertyName = "member_uuid")]
        public string? MemberUuid { get; set; }
    }
}
