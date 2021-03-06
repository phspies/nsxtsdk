// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Match type of HTTP header value
    /// </summary>
    [NSXTProperty(Description: @"Match type of HTTP header value")]
    public enum NSXTLbHttpResponseHeaderConditionMatchTypeEnumType
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
