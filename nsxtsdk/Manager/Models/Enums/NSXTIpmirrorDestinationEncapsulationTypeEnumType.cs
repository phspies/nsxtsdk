// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// You can choose GRE, ERSPAN II or ERSPAN III.
    /// </summary>
    [NSXTProperty(Description: @"You can choose GRE, ERSPAN II or ERSPAN III.")]
    public enum NSXTIpmirrorDestinationEncapsulationTypeEnumType
    {
        [EnumMember(Value = "GRE")]
        GRE = 1,
        [EnumMember(Value = "ERSPAN_TWO")]
        ERSPANTWO = 2,
        [EnumMember(Value = "ERSPAN_THREE")]
        ERSPANTHREE = 3,
    }
}
