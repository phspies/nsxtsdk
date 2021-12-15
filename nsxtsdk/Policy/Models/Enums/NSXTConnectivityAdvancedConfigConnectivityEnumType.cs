// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Connectivity configuration to manually connect (ON) or disconnect (OFF)a Tier1 segment from corresponding Tier1 gateway. Only valid for Tier1Segments.This property is ignored for L2 VPN extended segments when subnetsproperty is not specified.This property does not apply to VLAN backed segments. VLAN backed segmentswith connectivity OFF does not affect its layer-2 connectivity.
    /// </summary>
    [NSXTProperty(Description: @"Connectivity configuration to manually connect (ON) or disconnect (OFF)a Tier1 segment from corresponding Tier1 gateway. Only valid for Tier1Segments.This property is ignored for L2 VPN extended segments when subnetsproperty is not specified.This property does not apply to VLAN backed segments. VLAN backed segmentswith connectivity OFF does not affect its layer-2 connectivity.")]
    public enum NSXTConnectivityAdvancedConfigConnectivityEnumType
    {
        [EnumMember(Value = "ON")]
        ON = 1,
        [EnumMember(Value = "OFF")]
        OFF = 2,
    }
}