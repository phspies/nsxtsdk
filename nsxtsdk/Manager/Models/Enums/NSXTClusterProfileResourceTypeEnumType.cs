// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Supported cluster profiles.
    /// </summary>
    [NSXTProperty(Description: @"Supported cluster profiles.")]
    public enum NSXTClusterProfileResourceTypeEnumType
    {
        [EnumMember(Value = "EDGEHIGHAVAILABILITYPROFILE")]
        EdgeHighAvailabilityProfile = 1,
        [EnumMember(Value = "BRIDGEHIGHAVAILABILITYCLUSTERPROFILE")]
        BridgeHighAvailabilityClusterProfile = 2,
    }
}
