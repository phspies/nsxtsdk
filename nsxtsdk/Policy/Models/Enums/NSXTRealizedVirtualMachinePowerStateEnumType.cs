// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Current power state of this virtual machine in the system.
    /// </summary>
    [NSXTProperty(Description: @"Current power state of this virtual machine in the system.")]
    public enum NSXTRealizedVirtualMachinePowerStateEnumType
    {
        [EnumMember(Value = "VM_RUNNING")]
        VMRUNNING = 1,
        [EnumMember(Value = "VM_STOPPED")]
        VMSTOPPED = 2,
        [EnumMember(Value = "VM_SUSPENDED")]
        VMSUSPENDED = 3,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 4,
    }
}
