// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Case sensitivity to use for the matching.Enum options - SENSITIVE, INSENSITIVE.Default value when not specified in API or module isinterpreted by ALB Controller as INSENSITIVE.
    /// </summary>
    [NSXTProperty(Description: @"Case sensitivity to use for the matching.Enum options - SENSITIVE, INSENSITIVE.Default value when not specified in API or module isinterpreted by ALB Controller as INSENSITIVE.")]
    public enum NSXTAlbpathMatchMatchCaseEnumType
    {
        [EnumMember(Value = "SENSITIVE")]
        SENSITIVE = 1,
        [EnumMember(Value = "INSENSITIVE")]
        INSENSITIVE = 0,
    }
}
