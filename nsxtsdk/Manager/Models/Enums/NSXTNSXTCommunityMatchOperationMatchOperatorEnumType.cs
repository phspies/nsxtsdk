// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Match operator for communities from provided community list id.MATCH_ANY will match any communityMATCH_ALL will match all communitiesMATCH_EXACT will do exact match on communityMATCH_NONE [operator not supported] will not match any communityMATCH_REGEX will match normal communities by evaluating regularexpressionMATCH_LARGE_COMMUNITY_REGEX will match large communities by evaluatingregular expression
    /// </summary>
    [NSXTProperty(Description: @"Match operator for communities from provided community list id.MATCH_ANY will match any communityMATCH_ALL will match all communitiesMATCH_EXACT will do exact match on communityMATCH_NONE [operator not supported] will not match any communityMATCH_REGEX will match normal communities by evaluating regularexpressionMATCH_LARGE_COMMUNITY_REGEX will match large communities by evaluatingregular expression")]
    public enum NSXTCommunityMatchOperationMatchOperatorEnumType
    {
        [EnumMember(Value = "MATCH_ANY")]
        MATCHANY = 1,
        [EnumMember(Value = "MATCH_ALL")]
        MATCHALL = 2,
        [EnumMember(Value = "MATCH_EXACT")]
        MATCHEXACT = 3,
        [EnumMember(Value = "MATCH_NONE")]
        MATCHNONE = 4,
        [EnumMember(Value = "MATCH_REGEX")]
        MATCHREGEX = 5,
        [EnumMember(Value = "MATCH_LARGE_COMMUNITY_REGEX")]
        MATCHLARGECOMMUNITYREGEX = 6,
    }
}
