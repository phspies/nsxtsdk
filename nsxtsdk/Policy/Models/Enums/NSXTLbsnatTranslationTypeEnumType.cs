// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Snat translation type.
    /// </summary>
    [NSXTProperty(Description: @"Snat translation type.")]
    public enum NSXTLbsnatTranslationTypeEnumType
    {
        [EnumMember(Value = "LBSNATAUTOMAP")]
        LbsnatAutoMap = 1,
        [EnumMember(Value = "LBSNATIPPOOL")]
        LbsnatIpPool = 2,
        [EnumMember(Value = "LBSNATDISABLED")]
        LbsnatDisabled = 3,
    }
}
