// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Packet capture session status.
    /// </summary>
    [NSXTProperty(Description: @"Packet capture session status.")]
    public enum NSXTPacketCaptureSessionSessionstatusEnumType
    {
        [EnumMember(Value = "CREATED")]
        CREATED = 1,
        [EnumMember(Value = "STARTED")]
        STARTED = 2,
        [EnumMember(Value = "STOPPED")]
        STOPPED = 3,
        [EnumMember(Value = "FINISHED")]
        FINISHED = 4,
        [EnumMember(Value = "ERROR")]
        ERROR = 5,
    }
}
