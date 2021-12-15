// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Specifies the disk provisioning type of the VM.
    /// </summary>
    [NSXTProperty(Description: @"Specifies the disk provisioning type of the VM.")]
    public enum NSXTVsphereClusterNodeVmdeploymentConfigDiskProvisioningEnumType
    {
        [EnumMember(Value = "THIN")]
        THIN = 1,
        [EnumMember(Value = "LAZY_ZEROED_THICK")]
        LAZYZEROEDTHICK = 2,
        [EnumMember(Value = "EAGER_ZEROED_THICK")]
        EAGERZEROEDTHICK = 3,
    }
}
