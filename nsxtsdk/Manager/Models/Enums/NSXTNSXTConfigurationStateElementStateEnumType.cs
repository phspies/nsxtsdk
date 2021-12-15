// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// State of configuration on this sub system
    /// </summary>
    [NSXTProperty(Description: @"State of configuration on this sub system")]
    public enum NSXTConfigurationStateElementStateEnumType
    {
        [EnumMember(Value = "IN_PROGRESS")]
        InProgress = 1,
        [EnumMember(Value = "SUCCESS")]
        Success = 2,
        [EnumMember(Value = "FAILED")]
        Failed = 3,
        [EnumMember(Value = "PARTIAL_SUCCESS")]
        PartialSuccess = 4,
        [EnumMember(Value = "IN_SYNC")]
        InSync = 5,
        [EnumMember(Value = "VM_DEPLOYMENT_FAILED")]
        VMDEPLOYMENTFAILED = 6,
        [EnumMember(Value = "VM_POWER_ON_FAILED")]
        VMPOWERONFAILED = 7,
        [EnumMember(Value = "VM_POWER_OFF_FAILED")]
        VMPOWEROFFFAILED = 8,
        [EnumMember(Value = "VM_UNDEPLOY_FAILED")]
        VMUNDEPLOYFAILED = 9,
        [EnumMember(Value = "REPLACE_FAILED")]
        REPLACEFAILED = 10,
        [EnumMember(Value = "UPLINK_FROM_TEAMING_POLICY_NOT_MAPPED")]
        UPLINKFROMTEAMINGPOLICYNOTMAPPED = 11,
        [EnumMember(Value = "LOGICAL_SWITCH_NAMED_TEAMING_HAS_NO_PNIC_BACKING")]
        LOGICALSWITCHNAMEDTEAMINGHASNOPNICBACKING = 12,
        [EnumMember(Value = "DELETE_VM_IN_REDEPLOY_FAILED")]
        DELETEVMINREDEPLOYFAILED = 13,
        [EnumMember(Value = "DEPLOY_VM_IN_REDEPLOY_FAILED")]
        DEPLOYVMINREDEPLOYFAILED = 14,
        [EnumMember(Value = "INSUFFICIENT_RESOURCES_IN_EDGE_NODE_FOR_SERVICE")]
        INSUFFICIENTRESOURCESINEDGENODEFORSERVICE = 15,
        [EnumMember(Value = "EDGE_CONFIG_ERROR")]
        EDGECONFIGERROR = 16,
        [EnumMember(Value = "REGISTRATION_FAILED")]
        REGISTRATIONFAILED = 17,
        [EnumMember(Value = "TRANSPORT_NODE_CONFIGURATION_MISSING")]
        TRANSPORTNODECONFIGURATIONMISSING = 18,
        [EnumMember(Value = "EDGE_HARDWARE_NOT_SUPPORTED")]
        EDGEHARDWARENOTSUPPORTED = 19,
        [EnumMember(Value = "MULTIPLE_OVERLAY_TZS_NOT_SUPPORTED")]
        MULTIPLEOVERLAYTZSNOTSUPPORTED = 20,
        [EnumMember(Value = "TN_OVERLAY_TZ_IN_USE_BY_EDGE_CLUSTER")]
        TNOVERLAYTZINUSEBYEDGECLUSTER = 21,
        [EnumMember(Value = "TZ_ENDPOINTS_NOT_SPECIFIED")]
        TZENDPOINTSNOTSPECIFIED = 22,
        [EnumMember(Value = "NO_PNIC_PREPARED_IN_EDGE")]
        NOPNICPREPAREDINEDGE = 23,
        [EnumMember(Value = "APPLIANCE_INTERNAL_ERROR")]
        APPLIANCEINTERNALERROR = 24,
        [EnumMember(Value = "VTEP_DHCP_NOT_SUPPORTED")]
        VTEPDHCPNOTSUPPORTED = 25,
        [EnumMember(Value = "UNSUPPORTED_HOST_SWITCH_PROFILE")]
        UNSUPPORTEDHOSTSWITCHPROFILE = 26,
        [EnumMember(Value = "UPLINK_HOST_SWITCH_PROFILE_NOT_SPECIFIED")]
        UPLINKHOSTSWITCHPROFILENOTSPECIFIED = 27,
        [EnumMember(Value = "HOSTSWITCH_PROFILE_NOT_FOUND")]
        HOSTSWITCHPROFILENOTFOUND = 28,
        [EnumMember(Value = "LLDP_SEND_ENABLED_NOT_SUPPORTED")]
        LLDPSENDENABLEDNOTSUPPORTED = 29,
        [EnumMember(Value = "UNSUPPORTED_NAMED_TEAMING_POLICY")]
        UNSUPPORTEDNAMEDTEAMINGPOLICY = 30,
        [EnumMember(Value = "LBSRCID_NOT_SUPPORTED_FOR_EDGE_VM")]
        LBSRCIDNOTSUPPORTEDFOREDGEVM = 31,
        [EnumMember(Value = "LACP_NOT_SUPPORTED_FOR_EDGE_VM")]
        LACPNOTSUPPORTEDFOREDGEVM = 32,
        [EnumMember(Value = "STANDBY_UPLINKS_NOT_SUPPORTED_FOR_EDGE_VM")]
        STANDBYUPLINKSNOTSUPPORTEDFOREDGEVM = 33,
        [EnumMember(Value = "MULTIPLE_ACTIVE_UPLINKS_NOT_SUPPORTED_FOR_EDGE")]
        MULTIPLEACTIVEUPLINKSNOTSUPPORTEDFOREDGE = 34,
        [EnumMember(Value = "UNSUPPORTED_LACP_LB_ALGO_FOR_NODE")]
        UNSUPPORTEDLACPLBALGOFORNODE = 35,
        [EnumMember(Value = "EDGE_NODE_VERSION_NOT_SUPPORTED")]
        EDGENODEVERSIONNOTSUPPORTED = 36,
        [EnumMember(Value = "NO_PNIC_SPECIFIED_IN_TN")]
        NOPNICSPECIFIEDINTN = 37,
        [EnumMember(Value = "INVALID_PNIC_DEVICE_NAME")]
        INVALIDPNICDEVICENAME = 38,
        [EnumMember(Value = "UNSUPPORTED_DEFAULT_TEAMING_POLICY")]
        UNSUPPORTEDDEFAULTTEAMINGPOLICY = 39,
        [EnumMember(Value = "MPA_DISCONNECTED")]
        MPADISCONNECTED = 40,
        [EnumMember(Value = "VM_NETWORK_EDIT_PENDING")]
        VMNETWORKEDITPENDING = 41,
        [EnumMember(Value = "VM_RENAME_PENDING")]
        VMRENAMEPENDING = 42,
        [EnumMember(Value = "VM_CONFIG_EDIT_PENDING")]
        VMCONFIGEDITPENDING = 43,
        [EnumMember(Value = "VM_NETWORK_EDIT_FAILED")]
        VMNETWORKEDITFAILED = 44,
        [EnumMember(Value = "VM_RENAME_FAILED")]
        VMRENAMEFAILED = 45,
        [EnumMember(Value = "VM_CONFIG_EDIT_FAILED")]
        VMCONFIGEDITFAILED = 46,
        [EnumMember(Value = "VM_CONFIG_DISCREPANCY")]
        VMCONFIGDISCREPANCY = 47,
        [EnumMember(Value = "VM_NODE_REFRESH_FAILED")]
        VMNODEREFRESHFAILED = 48,
        [EnumMember(Value = "VM_PLACEMENT_REFRESH_FAILED")]
        VMPLACEMENTREFRESHFAILED = 49,
        [EnumMember(Value = "NOT_AVAILABLE")]
        NOTAVAILABLE = 50,
        [EnumMember(Value = "REGISTRATION_TIMEDOUT")]
        REGISTRATIONTIMEDOUT = 51,
        [EnumMember(Value = "PENDING")]
        Pending = 52,
        [EnumMember(Value = "ORPHANED")]
        Orphaned = 53,
        [EnumMember(Value = "UNKNOWN")]
        Unknown = 54,
        [EnumMember(Value = "ERROR")]
        Error = 55,
    }
}
