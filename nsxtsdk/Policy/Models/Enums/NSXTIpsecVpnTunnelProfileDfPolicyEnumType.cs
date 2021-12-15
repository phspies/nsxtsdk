// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Defragmentation policy helps to handle defragmentation bit present in the inner packet. COPY copies the defragmentation bit from the inner IP packet into the outer packet. CLEAR ignores the defragmentation bit present in the inner packet.
    /// </summary>
    [NSXTProperty(Description: @"Defragmentation policy helps to handle defragmentation bit present in the inner packet. COPY copies the defragmentation bit from the inner IP packet into the outer packet. CLEAR ignores the defragmentation bit present in the inner packet.")]
    public enum NSXTIpsecVpnTunnelProfileDfPolicyEnumType
    {
        [EnumMember(Value = "COPY")]
        COPY = 1,
        [EnumMember(Value = "CLEAR")]
        CLEAR = 2,
    }
}
