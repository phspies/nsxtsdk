// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Consolidated Realized Status of an intent object.
    /// </summary>
    [NSXTProperty(Description: @"Consolidated Realized Status of an intent object.")]
    public enum NSXTConsolidatedStatusConsolidatedStatusEnumType
    {
        [EnumMember(Value = "SUCCESS")]
        SUCCESS = 1,
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS = 2,
        [EnumMember(Value = "ERROR")]
        ERROR = 3,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 4,
        [EnumMember(Value = "UNINITIALIZED")]
        UNINITIALIZED = 5,
    }
}
