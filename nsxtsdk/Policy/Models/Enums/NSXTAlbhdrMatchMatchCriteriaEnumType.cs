// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Criterion to use for matching headers in the HTTP request.Enum options - HDR_EXISTS, HDR_DOES_NOT_EXIST,HDR_BEGINS_WITH, HDR_DOES_NOT_BEGIN_WITH, HDR_CONTAINS,HDR_DOES_NOT_CONTAIN, HDR_ENDS_WITH, HDR_DOES_NOT_END_WITH,HDR_EQUALS, HDR_DOES_NOT_EQUAL.
    /// </summary>
    [NSXTProperty(Description: @"Criterion to use for matching headers in the HTTP request.Enum options - HDR_EXISTS, HDR_DOES_NOT_EXIST,HDR_BEGINS_WITH, HDR_DOES_NOT_BEGIN_WITH, HDR_CONTAINS,HDR_DOES_NOT_CONTAIN, HDR_ENDS_WITH, HDR_DOES_NOT_END_WITH,HDR_EQUALS, HDR_DOES_NOT_EQUAL.")]
    public enum NSXTAlbhdrMatchMatchCriteriaEnumType
    {
        [EnumMember(Value = "HDR_EXISTS")]
        HDREXISTS = 1,
        [EnumMember(Value = "HDR_DOES_NOT_EXIST")]
        HDRDOESNOTEXIST = 2,
        [EnumMember(Value = "HDR_BEGINS_WITH")]
        HDRBEGINSWITH = 3,
        [EnumMember(Value = "HDR_DOES_NOT_BEGIN_WITH")]
        HDRDOESNOTBEGINWITH = 4,
        [EnumMember(Value = "HDR_CONTAINS")]
        HDRCONTAINS = 5,
        [EnumMember(Value = "HDR_DOES_NOT_CONTAIN")]
        HDRDOESNOTCONTAIN = 6,
        [EnumMember(Value = "HDR_ENDS_WITH")]
        HDRENDSWITH = 7,
        [EnumMember(Value = "HDR_DOES_NOT_END_WITH")]
        HDRDOESNOTENDWITH = 8,
        [EnumMember(Value = "HDR_EQUALS")]
        HDREQUALS = 9,
        [EnumMember(Value = "HDR_DOES_NOT_EQUAL")]
        HDRDOESNOTEQUAL = 10,
    }
}
