// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Allows user to select type of port mirroring session.
    /// </summary>
    [NSXTProperty(Description: @"Allows user to select type of port mirroring session.")]
    public enum NSXTPortMirroringProfileProfileTypeEnumType
    {
        [EnumMember(Value = "REMOTE_L3_SPAN")]
        REMOTEL3SPAN = 1,
        [EnumMember(Value = "LOGICAL_SPAN")]
        LOGICALSPAN = 2,
    }
}
