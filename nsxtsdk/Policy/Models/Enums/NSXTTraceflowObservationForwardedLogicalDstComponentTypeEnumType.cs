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
        [EnumMember(Value = "LOAD_BALANCER")]
        LOADBALANCER = 9,
        [EnumMember(Value = "NAT")]
        NAT = 10,
        [EnumMember(Value = "IPSEC")]
        IPSEC = 11,
        [EnumMember(Value = "SERVICE_INSERTION")]
        SERVICEINSERTION = 12,
        [EnumMember(Value = "VMC")]
        VMC = 13,
        [EnumMember(Value = "SPOOFGUARD")]
        SPOOFGUARD = 14,
        [EnumMember(Value = "EDGE_FW")]
        EDGEFW = 15,
        [EnumMember(Value = "DLB")]
        DLB = 16,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 17,
    }
}
