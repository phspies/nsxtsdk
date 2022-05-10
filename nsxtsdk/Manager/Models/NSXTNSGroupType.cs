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
    public class NSXTNSGroupType : NSXTManagedResourceType
    {
        /// <summary>
        /// Count of the members added to this NSGroup
        /// </summary>
        [JsonProperty(PropertyName = "member_count")]
        public long? MemberCount { get; set; }
        /// <summary>
        /// Reference to the direct/static members of the NSGroup.
        /// Can be ID based expressions only. VirtualMachine cannot
        /// be added as a static member.
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<NSXTNSGroupSimpleExpressionType> Members { get; set; }
        /// <summary>
        /// List of tag or name based expressions which define the dynamic membership criteria
        /// for this NSGroup. An object must satisfy atleast one of these expressions
        /// to qualify as a member of this group.
        /// It is not recommended to use ID based expressions in this section.
        /// ID based expression should be used in "members" section
        /// </summary>
        [JsonProperty(PropertyName = "membership_criteria")]
        public IList<NSXTNSGroupExpressionType> MembershipCriteria { get; set; }
    }
}
