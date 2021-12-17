// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// The reason traceflow packet was dropped
    /// </summary>
    [NSXTProperty(Description: @"The reason traceflow packet was dropped")]
    public enum NSXTTraceflowObservationDroppedReasonEnumType
    {
        [EnumMember(Value = "ARP_FAIL")]
        ARPFAIL = 1,
        [EnumMember(Value = "BFD")]
        BFD = 2,
        [EnumMember(Value = "BROADCAST")]
        BROADCAST = 3,
        [EnumMember(Value = "DHCP")]
        DHCP = 4,
        [EnumMember(Value = "DLB")]
        DLB = 5,
        [EnumMember(Value = "FW_RULE")]
        FWRULE = 6,
        [EnumMember(Value = "GENEVE")]
        GENEVE = 7,
        [EnumMember(Value = "GRE")]
        GRE = 8,
        [EnumMember(Value = "IFACE")]
        IFACE = 9,
        [EnumMember(Value = "IP")]
        IP = 10,
        [EnumMember(Value = "IP_REASS")]
        IPREASS = 11,
        [EnumMember(Value = "IPSEC")]
        IPSEC = 12,
        [EnumMember(Value = "IPSEC_VTI")]
        IPSECVTI = 13,
        [EnumMember(Value = "L2VPN")]
        L2VPN = 14,
        [EnumMember(Value = "L4PORT")]
        L4PORT = 15,
        [EnumMember(Value = "LB")]
        LB = 16,
        [EnumMember(Value = "LROUTER")]
        LROUTER = 17,
        [EnumMember(Value = "LSERVICE")]
        LSERVICE = 18,
        [EnumMember(Value = "LSWITCH")]
        LSWITCH = 19,
        [EnumMember(Value = "MANAGEMENT")]
        MANAGEMENT = 20,
        [EnumMember(Value = "MD_PROXY")]
        MDPROXY = 21,
        [EnumMember(Value = "NAT")]
        NAT = 22,
        [EnumMember(Value = "RTEP_TUNNEL")]
        RTEPTUNNEL = 23,
        [EnumMember(Value = "ND_NS_FAIL")]
        NDNSFAIL = 24,
        [EnumMember(Value = "NEIGH")]
        NEIGH = 25,
        [EnumMember(Value = "NO_EIP_FOUND")]
        NOEIPFOUND = 26,
        [EnumMember(Value = "NO_EIP_ASSOCIATION")]
        NOEIPASSOCIATION = 27,
        [EnumMember(Value = "NO_ENI_FOR_IP")]
        NOENIFORIP = 28,
        [EnumMember(Value = "NO_ENI_FOR_LIF")]
        NOENIFORLIF = 29,
        [EnumMember(Value = "NO_ROUTE")]
        NOROUTE = 30,
        [EnumMember(Value = "NO_ROUTE_TABLE_FOUND")]
        NOROUTETABLEFOUND = 31,
        [EnumMember(Value = "NO_UNDERLAY_ROUTE_FOUND")]
        NOUNDERLAYROUTEFOUND = 32,
        [EnumMember(Value = "NOT_VDR_DOWNLINK")]
        NOTVDRDOWNLINK = 33,
        [EnumMember(Value = "NO_VDR_FOUND")]
        NOVDRFOUND = 34,
        [EnumMember(Value = "NO_VDR_ON_HOST")]
        NOVDRONHOST = 35,
        [EnumMember(Value = "NOT_VDR_UPLINK")]
        NOTVDRUPLINK = 36,
        [EnumMember(Value = "SERVICE_INSERT")]
        SERVICEINSERT = 37,
        [EnumMember(Value = "SPOOFGUARD")]
        SPOOFGUARD = 38,
        [EnumMember(Value = "TTL_ZERO")]
        TTLZERO = 39,
        [EnumMember(Value = "TUNNEL")]
        TUNNEL = 40,
        [EnumMember(Value = "VLAN")]
        VLAN = 41,
        [EnumMember(Value = "VXLAN")]
        VXLAN = 42,
        [EnumMember(Value = "VXSTT")]
        VXSTT = 43,
        [EnumMember(Value = "VMC_NO_RESPONSE")]
        VMCNORESPONSE = 44,
        [EnumMember(Value = "WRONG_UPLINK")]
        WRONGUPLINK = 45,
        [EnumMember(Value = "FW_STATE")]
        FWSTATE = 46,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 47,
    }
}
