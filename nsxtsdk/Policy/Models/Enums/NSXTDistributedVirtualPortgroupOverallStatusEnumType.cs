// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// This parameters reflects the managed entity status of the portgroupas reported by VC.
    /// </summary>
    [NSXTProperty(Description: @"This parameters reflects the managed entity status of the portgroupas reported by VC.")]
    public enum NSXTDistributedVirtualPortgroupOverallStatusEnumType
    {
        [EnumMember(Value = "RED")]
        RED = 1,
        [EnumMember(Value = "YELLOW")]
        YELLOW = 2,
        [EnumMember(Value = "GREEN")]
        GREEN = 3,
        [EnumMember(Value = "GRAY")]
        GRAY = 4,
    }
}
