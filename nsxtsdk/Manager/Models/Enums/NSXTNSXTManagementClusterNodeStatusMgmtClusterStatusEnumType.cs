// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Status of this node&apos;s connection to the management cluster
    /// </summary>
    [NSXTProperty(Description: @"Status of this node&apos;s connection to the management cluster")]
    public enum NSXTManagementClusterNodeStatusMgmtClusterStatusEnumType
    {
        [EnumMember(Value = "CONNECTED")]
        CONNECTED = 1,
        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED = 2,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 3,
    }
}
