// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Port mirroring session direction
    /// </summary>
    [NSXTProperty(Description: @"Port mirroring session direction")]
    public enum NSXTPortMirroringSessionDirectionEnumType
    {
        [EnumMember(Value = "INGRESS")]
        INGRESS = 1,
        [EnumMember(Value = "EGRESS")]
        EGRESS = 2,
        [EnumMember(Value = "BIDIRECTIONAL")]
        BIDIRECTIONAL = 3,
    }
}
