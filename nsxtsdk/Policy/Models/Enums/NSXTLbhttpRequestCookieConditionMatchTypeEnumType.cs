// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Match type of cookie value.
    /// </summary>
    [NSXTProperty(Description: @"Match type of cookie value.")]
    public enum NSXTLbhttpRequestCookieConditionMatchTypeEnumType
    {
        [EnumMember(Value = "STARTS_WITH")]
        STARTSWITH = 1,
        [EnumMember(Value = "ENDS_WITH")]
        ENDSWITH = 2,
        [EnumMember(Value = "EQUALS")]
        EQUALS = 3,
        [EnumMember(Value = "CONTAINS")]
        CONTAINS = 4,
        [EnumMember(Value = "REGEX")]
        REGEX = 0,
    }
}
