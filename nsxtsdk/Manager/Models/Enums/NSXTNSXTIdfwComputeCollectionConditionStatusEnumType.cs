// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// IDFW enabled Compute collection status.
    /// </summary>
    [NSXTProperty(Description: @"IDFW enabled Compute collection status.")]
    public enum NSXTIdfwComputeCollectionConditionStatusEnumType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 1,
        [EnumMember(Value = "UP")]
        UP = 2,
        [EnumMember(Value = "DOWN")]
        DOWN = 3,
        [EnumMember(Value = "DFW_DISABLED")]
        DFWDISABLED = 4,
        [EnumMember(Value = "IDFW_DISABLED")]
        IDFWDISABLED = 5,
    }
}
