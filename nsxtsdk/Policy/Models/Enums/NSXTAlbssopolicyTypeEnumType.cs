// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// SSO Policy Type.Enum options - SSO_TYPE_SAML, SSO_TYPE_PINGACCESS,SSO_TYPE_JWT.Default value when not specified in API or module isinterpreted by ALB Controller as SSO_TYPE_SAML.
    /// </summary>
    [NSXTProperty(Description: @"SSO Policy Type.Enum options - SSO_TYPE_SAML, SSO_TYPE_PINGACCESS,SSO_TYPE_JWT.Default value when not specified in API or module isinterpreted by ALB Controller as SSO_TYPE_SAML.")]
    public enum NSXTAlbssopolicyTypeEnumType
    {
        [EnumMember(Value = "SSO_TYPE_SAML")]
        SSOTYPESAML = 1,
        [EnumMember(Value = "SSO_TYPE_PINGACCESS")]
        SSOTYPEPINGACCESS = 2,
        [EnumMember(Value = "SSO_TYPE_JWT")]
        SSOTYPEJWT = 3,
    }
}