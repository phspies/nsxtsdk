// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Realization state of this group
    /// </summary>
    [NSXTProperty(Description: @"Realization state of this group")]
    public enum NSXTGroupStateEnumType
    {
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS = 1,
        [EnumMember(Value = "SUCCESS")]
        SUCCESS = 2,
        [EnumMember(Value = "FAILURE")]
        FAILURE = 3,
    }
}
