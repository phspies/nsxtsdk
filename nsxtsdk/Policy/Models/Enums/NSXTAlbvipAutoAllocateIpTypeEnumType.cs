// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Specifies whether to auto-allocate only a V4 address, onlya V6 address, or one of each type.Enum options - V4_ONLY, V6_ONLY, V4_V6.Allowed in Basic(Allowed values- V4_ONLY) edition,Essentials(Allowed values- V4_ONLY) edition, Enterpriseedition.Default value when not specified in API or module isinterpreted by ALB Controller as V4_ONLY.
    /// </summary>
    [NSXTProperty(Description: @"Specifies whether to auto-allocate only a V4 address, onlya V6 address, or one of each type.Enum options - V4_ONLY, V6_ONLY, V4_V6.Allowed in Basic(Allowed values- V4_ONLY) edition,Essentials(Allowed values- V4_ONLY) edition, Enterpriseedition.Default value when not specified in API or module isinterpreted by ALB Controller as V4_ONLY.")]
    public enum NSXTAlbvipAutoAllocateIpTypeEnumType
    {
        [EnumMember(Value = "V4_ONLY")]
        V4ONLY = 1,
        [EnumMember(Value = "V6_ONLY")]
        V6ONLY = 2,
        [EnumMember(Value = "V4_V6")]
        V4V6 = 3,
    }
}
