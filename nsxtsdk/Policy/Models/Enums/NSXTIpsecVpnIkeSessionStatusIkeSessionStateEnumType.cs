// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Ike session service status UP, DOWN and NEGOTIATING.
    /// </summary>
    [NSXTProperty(Description: @"Ike session service status UP, DOWN and NEGOTIATING.")]
    public enum NSXTIpsecVpnIkeSessionStatusIkeSessionStateEnumType
    {
        [EnumMember(Value = "UP")]
        UP = 1,
        [EnumMember(Value = "DOWN")]
        DOWN = 2,
        [EnumMember(Value = "NEGOTIATING")]
        NEGOTIATING = 3,
    }
}
