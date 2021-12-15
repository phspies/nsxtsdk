// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Status of the addition or deletion of an auto-deployed cluster node VM.
    /// </summary>
    [NSXTProperty(Description: @"Status of the addition or deletion of an auto-deployed cluster node VM.")]
    public enum NSXTClusterNodeVmdeploymentStatusReportStatusEnumType
    {
        [EnumMember(Value = "UNKNOWN_STATE")]
        UNKNOWNSTATE = 1,
        [EnumMember(Value = "VM_DEPLOYMENT_QUEUED")]
        VMDEPLOYMENTQUEUED = 2,
        [EnumMember(Value = "VM_DEPLOYMENT_IN_PROGRESS")]
        VMDEPLOYMENTINPROGRESS = 3,
        [EnumMember(Value = "VM_DEPLOYMENT_FAILED")]
        VMDEPLOYMENTFAILED = 4,
        [EnumMember(Value = "VM_POWER_ON_IN_PROGRESS")]
        VMPOWERONINPROGRESS = 5,
        [EnumMember(Value = "VM_POWER_ON_FAILED")]
        VMPOWERONFAILED = 6,
        [EnumMember(Value = "WAITING_TO_REGISTER_VM")]
        WAITINGTOREGISTERVM = 7,
        [EnumMember(Value = "VM_REGISTRATION_FAILED")]
        VMREGISTRATIONFAILED = 8,
        [EnumMember(Value = "VM_WAITING_TO_CLUSTER")]
        VMWAITINGTOCLUSTER = 9,
        [EnumMember(Value = "VM_WAITING_TO_COME_ONLINE")]
        VMWAITINGTOCOMEONLINE = 10,
        [EnumMember(Value = "VM_ONLINE_FAILED")]
        VMONLINEFAILED = 11,
        [EnumMember(Value = "VM_CLUSTERING_IN_PROGRESS")]
        VMCLUSTERINGINPROGRESS = 12,
        [EnumMember(Value = "VM_CLUSTERING_FAILED")]
        VMCLUSTERINGFAILED = 13,
        [EnumMember(Value = "VM_CLUSTERING_SUCCESSFUL")]
        VMCLUSTERINGSUCCESSFUL = 14,
        [EnumMember(Value = "WAITING_TO_UNDEPLOY_VM")]
        WAITINGTOUNDEPLOYVM = 15,
        [EnumMember(Value = "VM_DECLUSTER_IN_PROGRESS")]
        VMDECLUSTERINPROGRESS = 16,
        [EnumMember(Value = "VM_DECLUSTER_FAILED")]
        VMDECLUSTERFAILED = 17,
        [EnumMember(Value = "VM_DECLUSTER_SUCCESSFUL")]
        VMDECLUSTERSUCCESSFUL = 18,
        [EnumMember(Value = "VM_POWER_OFF_IN_PROGRESS")]
        VMPOWEROFFINPROGRESS = 19,
        [EnumMember(Value = "VM_POWER_OFF_FAILED")]
        VMPOWEROFFFAILED = 20,
        [EnumMember(Value = "VM_UNDEPLOY_IN_PROGRESS")]
        VMUNDEPLOYINPROGRESS = 21,
        [EnumMember(Value = "VM_UNDEPLOY_FAILED")]
        VMUNDEPLOYFAILED = 22,
        [EnumMember(Value = "VM_UNDEPLOY_SUCCESSFUL")]
        VMUNDEPLOYSUCCESSFUL = 23,
    }
}