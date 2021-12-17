// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// App connectivity strategies
    /// </summary>
    [NSXTProperty(Description: @"App connectivity strategies")]
    public enum NSXTApplicationConnectivityStrategyApplicationConnectivityStrategyEnumType
    {
        [EnumMember(Value = "ALLOW_INTRA")]
        ALLOWINTRA = 1,
        [EnumMember(Value = "ALLOW_EGRESS")]
        ALLOWEGRESS = 2,
        [EnumMember(Value = "ALLOW_INGRESS")]
        ALLOWINGRESS = 3,
        [EnumMember(Value = "DROP_INGRESS")]
        DROPINGRESS = 4,
        [EnumMember(Value = "DROP_EGRESS")]
        DROPEGRESS = 5,
    }
}
