// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Represents the type of operation in the mp to policy promotion life cycle. Can be INITIATED, CANCELLED, PARTIAL_SUCCESS  or SUCCESS.
    /// </summary>
    [NSXTProperty(Description: @"Represents the type of operation in the mp to policy promotion life cycle. Can be INITIATED, CANCELLED, PARTIAL_SUCCESS  or SUCCESS.")]
    public enum NSXTMppolicyPromotionHistoryStatusEnumType
    {
        [EnumMember(Value = "INITIATED")]
        INITIATED = 1,
        [EnumMember(Value = "CANCELLED")]
        CANCELLED = 2,
        [EnumMember(Value = "SUCCESS")]
        SUCCESS = 3,
        [EnumMember(Value = "PARTIAL_SUCCESS")]
        PARTIALSUCCESS = 4,
    }
}
