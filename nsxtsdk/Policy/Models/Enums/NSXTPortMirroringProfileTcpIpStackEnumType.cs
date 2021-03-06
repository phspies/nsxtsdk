// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// User can provide Mirror stack or Default stack to send mirror traffic. If profile type is REMOTE_L3_SPAN, tcp_ip_stack type is used else ignored.
    /// </summary>
    [NSXTProperty(Description: @"User can provide Mirror stack or Default stack to send mirror traffic. If profile type is REMOTE_L3_SPAN, tcp_ip_stack type is used else ignored.")]
    public enum NSXTPortMirroringProfileTcpIpStackEnumType
    {
        [EnumMember(Value = "DEFAULT")]
        Default = 1,
        [EnumMember(Value = "MIRROR")]
        Mirror = 2,
    }
}
