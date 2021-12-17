// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// The source where the intrusion was detected. Possible values are GATEWAY and HOST.
    /// </summary>
    [NSXTProperty(Description: @"The source where the intrusion was detected. Possible values are GATEWAY and HOST.")]
    public enum NSXTPolicyIdsEventFlowDataTrafficTypeEnumType
    {
        [EnumMember(Value = "GATEWAY")]
        GATEWAY = 1,
        [EnumMember(Value = "HOST")]
        HOST = 2,
    }
}
