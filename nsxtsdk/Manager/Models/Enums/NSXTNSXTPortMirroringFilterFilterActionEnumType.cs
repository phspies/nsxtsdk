// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// If set to MIRROR, packets will be mirrored. If set to DO_NOT_MIRROR, packets will not be mirrored.
    /// </summary>
    [NSXTProperty(Description: @"If set to MIRROR, packets will be mirrored. If set to DO_NOT_MIRROR, packets will not be mirrored.")]
    public enum NSXTPortMirroringFilterFilterActionEnumType
    {
        [EnumMember(Value = "MIRROR")]
        MIRROR = 1,
        [EnumMember(Value = "DO_NOT_MIRROR")]
        DONOTMIRROR = 2,
    }
}