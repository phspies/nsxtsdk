// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Type of StringGroup.Enum options - SG_TYPE_STRING, SG_TYPE_KEYVAL.Default value when not specified in API or module isinterpreted by ALB Controller as SG_TYPE_STRING.
    /// </summary>
    [NSXTProperty(Description: @"Type of StringGroup.Enum options - SG_TYPE_STRING, SG_TYPE_KEYVAL.Default value when not specified in API or module isinterpreted by ALB Controller as SG_TYPE_STRING.")]
    public enum NSXTAlbstringGroupTypeEnumType
    {
        [EnumMember(Value = "SG_TYPE_STRING")]
        SGTYPESTRING = 1,
        [EnumMember(Value = "SG_TYPE_KEYVAL")]
        SGTYPEKEYVAL = 2,
    }
}
