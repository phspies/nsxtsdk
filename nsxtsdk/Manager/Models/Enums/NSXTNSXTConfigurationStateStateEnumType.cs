// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Gives details of state of desired configuration.Additional enums with more details on progress/success/error statesare sent for edge node. The success states are NODE_READY andTRANSPORT_NODE_READY, pending states are {VM_DEPLOYMENT_QUEUED,VM_DEPLOYMENT_IN_PROGRESS, REGISTRATION_PENDING} and other valuesindicate failures.&quot;in_sync&quot; state indicates that the desired configuration has beenreceived by the host to which it applies, but is not yet in effect.When the configuration is actually in effect, the state willchange to &quot;success&quot;.Please note, failed state is deprecated.
    /// </summary>
    [NSXTProperty(Description: @"Gives details of state of desired configuration.Additional enums with more details on progress/success/error statesare sent for edge node. The success states are NODE_READY andTRANSPORT_NODE_READY, pending states are {VM_DEPLOYMENT_QUEUED,VM_DEPLOYMENT_IN_PROGRESS, REGISTRATION_PENDING} and other valuesindicate failures.&quot;in_sync&quot; state indicates that the desired configuration has beenreceived by the host to which it applies, but is not yet in effect.When the configuration is actually in effect, the state willchange to &quot;success&quot;.Please note, failed state is deprecated.")]
    public enum NSXTConfigurationStateStateEnumType
    {
        [EnumMember(Value = "PENDING")]
        Pending = 1,
        [EnumMember(Value = "IN_PROGRESS")]
        InProgress = 2,
        [EnumMember(Value = "SUCCESS")]
        Success = 3,
        [EnumMember(Value = "FAILED")]
        Failed = 4,
        [EnumMember(Value = "PARTIAL_SUCCESS")]
        PartialSuccess = 5,
        [EnumMember(Value = "ORPHANED")]
        Orphaned = 6,
        [EnumMember(Value = "UNKNOWN")]
        Unknown = 7,
        [EnumMember(Value = "ERROR")]
        Error = 8,
        [EnumMember(Value = "IN_SYNC")]
        InSync = 9,
        [EnumMember(Value = "NOT_AVAILABLE")]
        NOTAVAILABLE = 10,
        [EnumMember(Value = "VM_DEPLOYMENT_QUEUED")]
        VMDEPLOYMENTQUEUED = 11,
        [EnumMember(Value = "VM_DEPLOYMENT_IN_PROGRESS")]
        VMDEPLOYMENTINPROGRESS = 12,
        [EnumMember(Value = "VM_DEPLOYMENT_FAILED")]
        VMDEPLOYMENTFAILED = 13,
        [EnumMember(Value = "VM_POWER_ON_IN_PROGRESS")]
        VMPOWERONINPROGRESS = 14,
        [EnumMember(Value = "VM_POWER_ON_FAILED")]
        VMPOWERONFAILED = 15,
        [EnumMember(Value = "REGISTRATION_PENDING")]
        REGISTRATIONPENDING = 16,
        [EnumMember(Value = "NODE_NOT_READY")]
        NODENOTREADY = 17,
        [EnumMember(Value = "NODE_READY")]
        NODEREADY = 18,
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
        [EnumMember(Value = "EDGE_CONFIG_ERROR")]
        EDGECONFIGERROR = 24,
        [EnumMember(Value = "VM_DEPLOYMENT_RESTARTED")]
        VMDEPLOYMENTRESTARTED = 25,
        [EnumMember(Value = "REGISTRATION_FAILED")]
        REGISTRATIONFAILED = 26,
        [EnumMember(Value = "TRANSPORT_NODE_SYNC_PENDING")]
        TRANSPORTNODESYNCPENDING = 27,
        [EnumMember(Value = "TRANSPORT_NODE_CONFIGURATION_MISSING")]
        TRANSPORTNODECONFIGURATIONMISSING = 28,
        [EnumMember(Value = "EDGE_HARDWARE_NOT_SUPPORTED")]
        EDGEHARDWARENOTSUPPORTED = 29,
        [EnumMember(Value = "MULTIPLE_OVERLAY_TZS_NOT_SUPPORTED")]
        MULTIPLEOVERLAYTZSNOTSUPPORTED = 30,
        [EnumMember(Value = "TN_OVERLAY_TZ_IN_USE_BY_EDGE_CLUSTER")]
        TNOVERLAYTZINUSEBYEDGECLUSTER = 31,
        [EnumMember(Value = "TZ_ENDPOINTS_NOT_SPECIFIED")]
        TZENDPOINTSNOTSPECIFIED = 32,
        [EnumMember(Value = "NO_PNIC_PREPARED_IN_EDGE")]
        NOPNICPREPAREDINEDGE = 33,
        [EnumMember(Value = "APPLIANCE_INTERNAL_ERROR")]
        APPLIANCEINTERNALERROR = 34,
        [EnumMember(Value = "VTEP_DHCP_NOT_SUPPORTED")]
        VTEPDHCPNOTSUPPORTED = 35,
        [EnumMember(Value = "UNSUPPORTED_HOST_SWITCH_PROFILE")]
        UNSUPPORTEDHOSTSWITCHPROFILE = 36,
        [EnumMember(Value = "UPLINK_HOST_SWITCH_PROFILE_NOT_SPECIFIED")]
        UPLINKHOSTSWITCHPROFILENOTSPECIFIED = 37,
        [EnumMember(Value = "HOSTSWITCH_PROFILE_NOT_FOUND")]
        HOSTSWITCHPROFILENOTFOUND = 38,
        [EnumMember(Value = "LLDP_SEND_ENABLED_NOT_SUPPORTED")]
        LLDPSENDENABLEDNOTSUPPORTED = 39,
        [EnumMember(Value = "UNSUPPORTED_NAMED_TEAMING_POLICY")]
        UNSUPPORTEDNAMEDTEAMINGPOLICY = 40,
        [EnumMember(Value = "LBSRCID_NOT_SUPPORTED_FOR_EDGE_VM")]
        LBSRCIDNOTSUPPORTEDFOREDGEVM = 41,
        [EnumMember(Value = "LACP_NOT_SUPPORTED_FOR_EDGE_VM")]
        LACPNOTSUPPORTEDFOREDGEVM = 42,
        [EnumMember(Value = "STANDBY_UPLINKS_NOT_SUPPORTED_FOR_EDGE_VM")]
        STANDBYUPLINKSNOTSUPPORTEDFOREDGEVM = 43,
        [EnumMember(Value = "MULTIPLE_ACTIVE_UPLINKS_NOT_SUPPORTED_FOR_EDGE")]
        MULTIPLEACTIVEUPLINKSNOTSUPPORTEDFOREDGE = 44,
        [EnumMember(Value = "UNSUPPORTED_LACP_LB_ALGO_FOR_NODE")]
        UNSUPPORTEDLACPLBALGOFORNODE = 45,
        [EnumMember(Value = "EDGE_NODE_VERSION_NOT_SUPPORTED")]
        EDGENODEVERSIONNOTSUPPORTED = 46,
        [EnumMember(Value = "NO_PNIC_SPECIFIED_IN_TN")]
        NOPNICSPECIFIEDINTN = 47,
        [EnumMember(Value = "INVALID_PNIC_DEVICE_NAME")]
        INVALIDPNICDEVICENAME = 48,
        [EnumMember(Value = "TRANSPORT_NODE_READY")]
        TRANSPORTNODEREADY = 49,
        [EnumMember(Value = "VM_NETWORK_EDIT_PENDING")]
        VMNETWORKEDITPENDING = 50,
        [EnumMember(Value = "UNSUPPORTED_DEFAULT_TEAMING_POLICY")]
        UNSUPPORTEDDEFAULTTEAMINGPOLICY = 51,
        [EnumMember(Value = "MPA_DISCONNECTED")]
        MPADISCONNECTED = 52,
        [EnumMember(Value = "VM_RENAME_PENDING")]
        VMRENAMEPENDING = 53,
        [EnumMember(Value = "VM_CONFIG_EDIT_PENDING")]
        VMCONFIGEDITPENDING = 54,
        [EnumMember(Value = "VM_NETWORK_EDIT_FAILED")]
        VMNETWORKEDITFAILED = 55,
        [EnumMember(Value = "VM_RENAME_FAILED")]
        VMRENAMEFAILED = 56,
        [EnumMember(Value = "VM_CONFIG_EDIT_FAILED")]
        VMCONFIGEDITFAILED = 57,
        [EnumMember(Value = "VM_CONFIG_DISCREPANCY")]
        VMCONFIGDISCREPANCY = 58,
        [EnumMember(Value = "VM_NODE_REFRESH_FAILED")]
        VMNODEREFRESHFAILED = 59,
        [EnumMember(Value = "VM_PLACEMENT_REFRESH_FAILED")]
        VMPLACEMENTREFRESHFAILED = 60,
        [EnumMember(Value = "REGISTRATION_TIMEDOUT")]
        REGISTRATIONTIMEDOUT = 61,
        [EnumMember(Value = "REPLACE_FAILED")]
        REPLACEFAILED = 62,
        [EnumMember(Value = "UPLINK_FROM_TEAMING_POLICY_NOT_MAPPED")]
        UPLINKFROMTEAMINGPOLICYNOTMAPPED = 63,
        [EnumMember(Value = "LOGICAL_SWITCH_NAMED_TEAMING_HAS_NO_PNIC_BACKING")]
        LOGICALSWITCHNAMEDTEAMINGHASNOPNICBACKING = 64,
        [EnumMember(Value = "DELETE_VM_IN_REDEPLOY_FAILED")]
        DELETEVMINREDEPLOYFAILED = 65,
        [EnumMember(Value = "DEPLOY_VM_IN_REDEPLOY_FAILED")]
        DEPLOYVMINREDEPLOYFAILED = 66,
        [EnumMember(Value = "INSUFFICIENT_RESOURCES_IN_EDGE_NODE_FOR_SERVICE")]
        INSUFFICIENTRESOURCESINEDGENODEFORSERVICE = 67,
    }
}