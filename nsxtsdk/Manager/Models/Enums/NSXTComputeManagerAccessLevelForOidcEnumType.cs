// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Specifies the maximum access level allowed for calls from compute managerto NSX using the OIDC provider.
    /// </summary>
    [NSXTProperty(Description: @"Specifies the maximum access level allowed for calls from compute managerto NSX using the OIDC provider.")]
    public enum NSXTComputeManagerAccessLevelForOidcEnumType
    {
        [EnumMember(Value = "FULL")]
        FULL = 1,
        [EnumMember(Value = "LIMITED")]
        LIMITED = 2,
    }
}
