// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// This field is a readonly field which shows the deployment_type of members.It returns UNKNOWN if there are no members, and returns VIRTUAL_MACHINE|PHYSICAL_MACHINE if all edge members are VIRTUAL_MACHINE|PHYSICAL_MACHINE.It returns HYBRID if the cluster contains edge members of both typesVIRTUAL_MACHINE and PHYSICAL_MACHINE.
    /// </summary>
    [NSXTProperty(Description: @"This field is a readonly field which shows the deployment_type of members.It returns UNKNOWN if there are no members, and returns VIRTUAL_MACHINE|PHYSICAL_MACHINE if all edge members are VIRTUAL_MACHINE|PHYSICAL_MACHINE.It returns HYBRID if the cluster contains edge members of both typesVIRTUAL_MACHINE and PHYSICAL_MACHINE.")]
    public enum NSXTEdgeClusterDeploymentTypeEnumType
    {
        [EnumMember(Value = "VIRTUAL_MACHINE")]
        VIRTUALMACHINE = 1,
        [EnumMember(Value = "PHYSICAL_MACHINE")]
        PHYSICALMACHINE = 2,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 3,
    }
}
