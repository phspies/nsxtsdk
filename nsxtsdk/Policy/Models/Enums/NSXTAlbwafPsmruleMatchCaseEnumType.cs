// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// The field match_value_pattern regular expression is casesensitive.Enum options - SENSITIVE, INSENSITIVE.Default value when not specified in API or module isinterpreted by ALB Controller as INSENSITIVE.
    /// </summary>
    [NSXTProperty(Description: @"The field match_value_pattern regular expression is casesensitive.Enum options - SENSITIVE, INSENSITIVE.Default value when not specified in API or module isinterpreted by ALB Controller as INSENSITIVE.")]
    public enum NSXTAlbwafPsmruleMatchCaseEnumType
    {
        [EnumMember(Value = "SENSITIVE")]
        SENSITIVE = 1,
        [EnumMember(Value = "INSENSITIVE")]
        INSENSITIVE = 0,
    }
}