// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Migration mode can be VMC_V2T, ONPREMISE_V2T, ONPREMISE_VSPHERE2T, DFW_ONLY, DFW_WITH_BRIDGED_SEG, CMP_VRA, DFW_AND_HOST_AND_WORKLOAD, DFW_AND_HOST_AND_WORKLOAD_WITH_BRIDGED_SEG, EDGE_CUTOVER
    /// </summary>
    [NSXTProperty(Description: @"Migration mode can be VMC_V2T, ONPREMISE_V2T, ONPREMISE_VSPHERE2T, DFW_ONLY, DFW_WITH_BRIDGED_SEG, CMP_VRA, DFW_AND_HOST_AND_WORKLOAD, DFW_AND_HOST_AND_WORKLOAD_WITH_BRIDGED_SEG, EDGE_CUTOVER")]
    public enum NSXTMigrationSetupInfoMigrationModeEnumType
    {
        [EnumMember(Value = "VMC_V2T")]
        VMCV2T = 1,
        [EnumMember(Value = "ONPREMISE_V2T")]
        ONPREMISEV2T = 0,
        [EnumMember(Value = "ONPREMISE_VSPHERE2T")]
        ONPREMISEVSPHERE2T = 1,
        [EnumMember(Value = "DFW_ONLY")]
        DFWONLY = 2,
        [EnumMember(Value = "DFW_WITH_BRIDGED_SEG")]
        DFWWITHBRIDGEDSEG = 3,
        [EnumMember(Value = "CMP_VRA")]
        CMPVRA = 4,
        [EnumMember(Value = "DFW_AND_HOST_AND_WORKLOAD")]
        DFWANDHOSTANDWORKLOAD = 5,
        [EnumMember(Value = "DFW_AND_HOST_AND_WORKLOAD_WITH_BRIDGED_SEG")]
        DFWANDHOSTANDWORKLOADWITHBRIDGEDSEG = 6,
        [EnumMember(Value = "EDGE_CUTOVER")]
        EDGECUTOVER = 7,
    }
}
