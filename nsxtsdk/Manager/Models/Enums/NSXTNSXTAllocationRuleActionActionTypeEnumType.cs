// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Set action for each allocation rule on edge cluster which will help inauto placement.
    /// </summary>
    [NSXTProperty(Description: @"Set action for each allocation rule on edge cluster which will help inauto placement.")]
    public enum NSXTAllocationRuleActionActionTypeEnumType
    {
        [EnumMember(Value = "ALLOCATIONBASEDONFAILUREDOMAIN")]
        AllocationBasedOnFailureDomain = 1,
    }
}