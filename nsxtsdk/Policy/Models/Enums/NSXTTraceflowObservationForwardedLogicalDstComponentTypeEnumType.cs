// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// The type of the destination component to which the traceflow packet was forwarded.
    /// </summary>
    [NSXTProperty(Description: @"The type of the destination component to which the traceflow packet was forwarded.")]
    public enum NSXTTraceflowObservationForwardedLogicalDstComponentTypeEnumType
    {
        [EnumMember(Value = "PHYSICAL")]
        PHYSICAL = 1,
        [EnumMember(Value = "LR")]
        LR = 2,
        [EnumMember(Value = "LS")]
        LS = 3,
        [EnumMember(Value = "DFW")]
        DFW = 4,
        [EnumMember(Value = "BRIDGE")]
        BRIDGE = 5,
        [EnumMember(Value = "EDGE_TUNNEL")]
        EDGETUNNEL = 6,
        [EnumMember(Value = "EDGE_HOSTSWITCH")]
        EDGEHOSTSWITCH = 7,
        [EnumMember(Value = "FW_BRIDGE")]
        FWBRIDGE = 8,
        [EnumMember(Value = "EDGE_RTEP_TUNNEL")]
        EDGERTEPTUNNEL = 9,
        [EnumMember(Value = "LOAD_BALANCER")]
        LOADBALANCER = 10,
        [EnumMember(Value = "NAT")]
        NAT = 11,
        [EnumMember(Value = "IPSEC")]
        IPSEC = 12,
        [EnumMember(Value = "SERVICE_INSERTION")]
        SERVICEINSERTION = 13,
        [EnumMember(Value = "VMC")]
        VMC = 14,
        [EnumMember(Value = "SPOOFGUARD")]
        SPOOFGUARD = 15,
        [EnumMember(Value = "EDGE_FW")]
        EDGEFW = 16,
        [EnumMember(Value = "DLB")]
        DLB = 17,
        [EnumMember(Value = "ANTREA_SPOOFGUARD")]
        ANTREASPOOFGUARD = 18,
        [EnumMember(Value = "ANTREA_LB")]
        ANTREALB = 19,
        [EnumMember(Value = "ANTREA_ROUTING")]
        ANTREAROUTING = 20,
        [EnumMember(Value = "ANTREA_DFW")]
        ANTREADFW = 21,
        [EnumMember(Value = "ANTREA_FORWARDING")]
        ANTREAFORWARDING = 22,
        [EnumMember(Value = "HOST_SWITCH")]
        HOSTSWITCH = 23,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 24,
    }
}
