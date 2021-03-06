// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Overall status of the flow
    /// </summary>
    [NSXTProperty(Description: @"Overall status of the flow")]
    public enum NSXTCrossSiteFlowInfoStatusEnumType
    {
        [EnumMember(Value = "GOOD")]
        GOOD = 1,
        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED = 2,
        [EnumMember(Value = "RECOVERY")]
        RECOVERY = 3,
        [EnumMember(Value = "ERROR")]
        ERROR = 4,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 5,
        [EnumMember(Value = "NOT_READY")]
        NOTREADY = 6,
    }
}
