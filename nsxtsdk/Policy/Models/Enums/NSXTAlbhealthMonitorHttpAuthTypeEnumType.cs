// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Type of the authentication method.Enum options - AUTH_BASIC, AUTH_NTLM.
    /// </summary>
    [NSXTProperty(Description: @"Type of the authentication method.Enum options - AUTH_BASIC, AUTH_NTLM.")]
    public enum NSXTAlbhealthMonitorHttpAuthTypeEnumType
    {
        [EnumMember(Value = "AUTH_BASIC")]
        AUTHBASIC = 1,
        [EnumMember(Value = "AUTH_NTLM")]
        AUTHNTLM = 2,
    }
}