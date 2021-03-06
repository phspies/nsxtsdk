// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Authentication mode used for the peer authentication. For PSK (Pre Shared Key) authentication mode, &apos;psk&apos; property is mandatory and for the CERTIFICATE authentication mode, &apos;peer_id&apos; property is mandatory.
    /// </summary>
    [NSXTProperty(Description: @"Authentication mode used for the peer authentication. For PSK (Pre Shared Key) authentication mode, &apos;psk&apos; property is mandatory and for the CERTIFICATE authentication mode, &apos;peer_id&apos; property is mandatory.")]
    public enum NSXTIpsecVpnpeerEndpointAuthenticationModeEnumType
    {
        [EnumMember(Value = "PSK")]
        PSK = 1,
        [EnumMember(Value = "CERTIFICATE")]
        CERTIFICATE = 2,
    }
}
