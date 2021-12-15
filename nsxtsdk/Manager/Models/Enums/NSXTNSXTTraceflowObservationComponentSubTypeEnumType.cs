// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// The sub type of the component that issued the observation.
    /// </summary>
    [NSXTProperty(Description: @"The sub type of the component that issued the observation.")]
    public enum NSXTTraceflowObservationComponentSubTypeEnumType
    {
        [EnumMember(Value = "LR_TIER0")]
        LRTIER0 = 1,
        [EnumMember(Value = "LR_TIER1")]
        LRTIER1 = 2,
        [EnumMember(Value = "LR_VRF_TIER0")]
        LRVRFTIER0 = 3,
        [EnumMember(Value = "LS_TRANSIT")]
        LSTRANSIT = 4,
        [EnumMember(Value = "SI_CLASSIFIER")]
        SICLASSIFIER = 5,
        [EnumMember(Value = "SI_PROXY")]
        SIPROXY = 6,
        [EnumMember(Value = "VDR")]
        VDR = 7,
        [EnumMember(Value = "ENI")]
        ENI = 8,
        [EnumMember(Value = "AWS_GATEWAY")]
        AWSGATEWAY = 9,
        [EnumMember(Value = "TGW_ROUTE")]
        TGWROUTE = 10,
        [EnumMember(Value = "EDGE_UPLINK")]
        EDGEUPLINK = 11,
        [EnumMember(Value = "DELL_GATEWAY")]
        DELLGATEWAY = 12,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 13,
    }
}
