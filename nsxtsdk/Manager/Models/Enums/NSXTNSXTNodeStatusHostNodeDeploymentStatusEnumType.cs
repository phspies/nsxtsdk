// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// This enum specifies the current nsx install state for host node orcurrent deployment and ready state for edge node.The ready status &apos;NODE_READY&apos; indicates whether edge node isready to become a transport node.The status &apos;EDGE_CONFIG_ERROR&apos; indicates that edge hardware or underlyinghost is not supported. After all fabric level operations are done for anedge node, this value indicates transport node related configurationissues and state as relevant.
    /// </summary>
    [NSXTProperty(Description: @"This enum specifies the current nsx install state for host node orcurrent deployment and ready state for edge node.The ready status &apos;NODE_READY&apos; indicates whether edge node isready to become a transport node.The status &apos;EDGE_CONFIG_ERROR&apos; indicates that edge hardware or underlyinghost is not supported. After all fabric level operations are done for anedge node, this value indicates transport node related configurationissues and state as relevant.")]
    public enum NSXTNodeStatusHostNodeDeploymentStatusEnumType
    {
        [EnumMember(Value = "NOT_PREPARED")]
        NOTPREPARED = 1,
        [EnumMember(Value = "INSTALL_IN_PROGRESS")]
        INSTALLINPROGRESS = 2,
        [EnumMember(Value = "INSTALL_FAILED")]
        INSTALLFAILED = 3,
        [EnumMember(Value = "INSTALL_SUCCESSFUL")]
        INSTALLSUCCESSFUL = 4,
        [EnumMember(Value = "INSTALL_SKIPPED")]
        INSTALLSKIPPED = 5,
        [EnumMember(Value = "UNINSTALL_IN_PROGRESS")]
        UNINSTALLINPROGRESS = 6,
        [EnumMember(Value = "UNINSTALL_FAILED")]
        UNINSTALLFAILED = 7,
        [EnumMember(Value = "UNINSTALL_SUCCESSFUL")]
        UNINSTALLSUCCESSFUL = 8,
        [EnumMember(Value = "UNINSTALL_SCHEDULED")]
        UNINSTALLSCHEDULED = 9,
        [EnumMember(Value = "UNINSTALL_SKIPPED")]
        UNINSTALLSKIPPED = 10,
        [EnumMember(Value = "UPGRADE_IN_PROGRESS")]
        UPGRADEINPROGRESS = 11,
        [EnumMember(Value = "UPGRADE_FAILED")]
        UPGRADEFAILED = 12,
        [EnumMember(Value = "PENDING_UPGRADE")]
        PENDINGUPGRADE = 13,
        [EnumMember(Value = "NOT_AVAILABLE")]
        NOTAVAILABLE = 14,
        [EnumMember(Value = "VM_DEPLOYMENT_QUEUED")]
        VMDEPLOYMENTQUEUED = 15,
        [EnumMember(Value = "VM_DEPLOYMENT_IN_PROGRESS")]
        VMDEPLOYMENTINPROGRESS = 16,
        [EnumMember(Value = "VM_DEPLOYMENT_FAILED")]
        VMDEPLOYMENTFAILED = 17,
        [EnumMember(Value = "VM_POWER_ON_IN_PROGRESS")]
        VMPOWERONINPROGRESS = 18,
        [EnumMember(Value = "VM_POWER_ON_FAILED")]
        VMPOWERONFAILED = 19,
        [EnumMember(Value = "REGISTRATION_PENDING")]
        REGISTRATIONPENDING = 20,
        [EnumMember(Value = "NODE_NOT_READY")]
        NODENOTREADY = 21,
        [EnumMember(Value = "NODE_READY")]
        NODEREADY = 22,
        [EnumMember(Value = "VM_POWER_OFF_IN_PROGRESS")]
        VMPOWEROFFINPROGRESS = 23,
        [EnumMember(Value = "VM_POWER_OFF_FAILED")]
        VMPOWEROFFFAILED = 24,
        [EnumMember(Value = "VM_UNDEPLOY_IN_PROGRESS")]
        VMUNDEPLOYINPROGRESS = 25,
        [EnumMember(Value = "VM_UNDEPLOY_FAILED")]
        VMUNDEPLOYFAILED = 26,
        [EnumMember(Value = "VM_UNDEPLOY_SUCCESSFUL")]
        VMUNDEPLOYSUCCESSFUL = 27,
        [EnumMember(Value = "EDGE_CONFIG_ERROR")]
        EDGECONFIGERROR = 28,
        [EnumMember(Value = "VM_DEPLOYMENT_RESTARTED")]
        VMDEPLOYMENTRESTARTED = 29,
        [EnumMember(Value = "REGISTRATION_FAILED")]
        REGISTRATIONFAILED = 30,
        [EnumMember(Value = "HOST_DISCONNECTED")]
        HOSTDISCONNECTED = 31,
        [EnumMember(Value = "POWERED_OFF")]
        POWEREDOFF = 32,
        [EnumMember(Value = "TRANSPORT_NODE_SYNC_PENDING")]
        TRANSPORTNODESYNCPENDING = 33,
        [EnumMember(Value = "TRANSPORT_NODE_CONFIGURATION_MISSING")]
        TRANSPORTNODECONFIGURATIONMISSING = 34,
        [EnumMember(Value = "EDGE_HARDWARE_NOT_SUPPORTED")]
        EDGEHARDWARENOTSUPPORTED = 35,
        [EnumMember(Value = "MULTIPLE_OVERLAY_TZS_NOT_SUPPORTED")]
        MULTIPLEOVERLAYTZSNOTSUPPORTED = 36,
        [EnumMember(Value = "TN_OVERLAY_TZ_IN_USE_BY_EDGE_CLUSTER")]
        TNOVERLAYTZINUSEBYEDGECLUSTER = 37,
        [EnumMember(Value = "TZ_ENDPOINTS_NOT_SPECIFIED")]
        TZENDPOINTSNOTSPECIFIED = 38,
        [EnumMember(Value = "NO_PNIC_PREPARED_IN_EDGE")]
        NOPNICPREPAREDINEDGE = 39,
        [EnumMember(Value = "APPLIANCE_INTERNAL_ERROR")]
        APPLIANCEINTERNALERROR = 40,
        [EnumMember(Value = "VTEP_DHCP_NOT_SUPPORTED")]
        VTEPDHCPNOTSUPPORTED = 41,
        [EnumMember(Value = "UNSUPPORTED_HOST_SWITCH_PROFILE")]
        UNSUPPORTEDHOSTSWITCHPROFILE = 42,
        [EnumMember(Value = "UPLINK_HOST_SWITCH_PROFILE_NOT_SPECIFIED")]
        UPLINKHOSTSWITCHPROFILENOTSPECIFIED = 43,
        [EnumMember(Value = "HOSTSWITCH_PROFILE_NOT_FOUND")]
        HOSTSWITCHPROFILENOTFOUND = 44,
        [EnumMember(Value = "LLDP_SEND_ENABLED_NOT_SUPPORTED")]
        LLDPSENDENABLEDNOTSUPPORTED = 45,
        [EnumMember(Value = "UNSUPPORTED_NAMED_TEAMING_POLICY")]
        UNSUPPORTEDNAMEDTEAMINGPOLICY = 46,
        [EnumMember(Value = "MULTIPLE_UPLINKS_IN_NAMED_TEAMING_NOT_SUPPORTED_IF_UPLINK_IN_DEFAULT_TEAMING")]
        MULTIPLEUPLINKSINNAMEDTEAMINGNOTSUPPORTEDIFUPLINKINDEFAULTTEAMING = 47,
        [EnumMember(Value = "LBSRCID_NOT_SUPPORTED_FOR_EDGE_VM")]
        LBSRCIDNOTSUPPORTEDFOREDGEVM = 48,
        [EnumMember(Value = "LACP_NOT_SUPPORTED_FOR_EDGE_VM")]
        LACPNOTSUPPORTEDFOREDGEVM = 49,
        [EnumMember(Value = "STANDBY_UPLINKS_NOT_SUPPORTED_FOR_EDGE_VM")]
        STANDBYUPLINKSNOTSUPPORTEDFOREDGEVM = 50,
        [EnumMember(Value = "MULTIPLE_ACTIVE_UPLINKS_NOT_SUPPORTED_FOR_EDGE")]
        MULTIPLEACTIVEUPLINKSNOTSUPPORTEDFOREDGE = 51,
        [EnumMember(Value = "UNSUPPORTED_LACP_LB_ALGO_FOR_NODE")]
        UNSUPPORTEDLACPLBALGOFORNODE = 52,
        [EnumMember(Value = "EDGE_NODE_VERSION_NOT_SUPPORTED")]
        EDGENODEVERSIONNOTSUPPORTED = 53,
        [EnumMember(Value = "NO_PNIC_SPECIFIED_IN_TN")]
        NOPNICSPECIFIEDINTN = 54,
        [EnumMember(Value = "INVALID_PNIC_DEVICE_NAME")]
        INVALIDPNICDEVICENAME = 55,
        [EnumMember(Value = "TRANSPORT_NODE_READY")]
        TRANSPORTNODEREADY = 56,
        [EnumMember(Value = "UNSUPPORTED_DEFAULT_TEAMING_POLICY")]
        UNSUPPORTEDDEFAULTTEAMINGPOLICY = 57,
        [EnumMember(Value = "MPA_DISCONNECTED")]
        MPADISCONNECTED = 58,
        [EnumMember(Value = "VM_NETWORK_EDIT_PENDING")]
        VMNETWORKEDITPENDING = 59,
        [EnumMember(Value = "VM_RENAME_PENDING")]
        VMRENAMEPENDING = 60,
        [EnumMember(Value = "VM_CONFIG_EDIT_PENDING")]
        VMCONFIGEDITPENDING = 61,
        [EnumMember(Value = "VM_NETWORK_EDIT_FAILED")]
        VMNETWORKEDITFAILED = 62,
        [EnumMember(Value = "VM_RENAME_FAILED")]
        VMRENAMEFAILED = 63,
        [EnumMember(Value = "VM_CONFIG_EDIT_FAILED")]
        VMCONFIGEDITFAILED = 64,
        [EnumMember(Value = "VM_CONFIG_DISCREPANCY")]
        VMCONFIGDISCREPANCY = 65,
        [EnumMember(Value = "VM_NODE_REFRESH_FAILED")]
        VMNODEREFRESHFAILED = 66,
        [EnumMember(Value = "VM_PLACEMENT_REFRESH_FAILED")]
        VMPLACEMENTREFRESHFAILED = 67,
        [EnumMember(Value = "REGISTRATION_TIMEDOUT")]
        REGISTRATIONTIMEDOUT = 68,
        [EnumMember(Value = "LOGICAL_SWITCH_NAMED_TEAMING_HAS_NO_PNIC_BACKING")]
        LOGICALSWITCHNAMEDTEAMINGHASNOPNICBACKING = 69,
        [EnumMember(Value = "UPLINK_FROM_TEAMING_POLICY_NOT_MAPPED")]
        UPLINKFROMTEAMINGPOLICYNOTMAPPED = 70,
        [EnumMember(Value = "REPLACE_FAILED")]
        REPLACEFAILED = 71,
        [EnumMember(Value = "DELETE_VM_IN_REDEPLOY_FAILED")]
        DELETEVMINREDEPLOYFAILED = 72,
        [EnumMember(Value = "DEPLOY_VM_IN_REDEPLOY_FAILED")]
        DEPLOYVMINREDEPLOYFAILED = 73,
        [EnumMember(Value = "INSUFFICIENT_RESOURCES_IN_EDGE_NODE_FOR_SERVICE")]
        INSUFFICIENTRESOURCESINEDGENODEFORSERVICE = 74,
    }
}
