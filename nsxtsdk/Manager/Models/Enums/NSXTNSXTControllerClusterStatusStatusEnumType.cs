// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// The current status of the controller cluster
    /// </summary>
    [NSXTProperty(Description: @"The current status of the controller cluster")]
    public enum NSXTControllerClusterStatusStatusEnumType
    {
        [EnumMember(Value = "NO_CONTROLLERS")]
        NOCONTROLLERS = 1,
        [EnumMember(Value = "UNSTABLE")]
        UNSTABLE = 2,
        [EnumMember(Value = "DEGRADED")]
        DEGRADED = 3,
        [EnumMember(Value = "STABLE")]
        STABLE = 4,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 5,
    }
}