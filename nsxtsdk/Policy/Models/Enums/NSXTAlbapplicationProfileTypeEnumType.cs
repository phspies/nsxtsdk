// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Specifies which application layer proxy is enabled for thevirtual service.Enum options - APPLICATION_PROFILE_TYPE_L4,APPLICATION_PROFILE_TYPE_HTTP,APPLICATION_PROFILE_TYPE_SYSLOG,APPLICATION_PROFILE_TYPE_DNS, APPLICATION_PROFILE_TYPE_SSL,APPLICATION_PROFILE_TYPE_SIP.
    /// </summary>
    [NSXTProperty(Description: @"Specifies which application layer proxy is enabled for thevirtual service.Enum options - APPLICATION_PROFILE_TYPE_L4,APPLICATION_PROFILE_TYPE_HTTP,APPLICATION_PROFILE_TYPE_SYSLOG,APPLICATION_PROFILE_TYPE_DNS, APPLICATION_PROFILE_TYPE_SSL,APPLICATION_PROFILE_TYPE_SIP.")]
    public enum NSXTAlbapplicationProfileTypeEnumType
    {
        [EnumMember(Value = "APPLICATION_PROFILE_TYPE_L4")]
        APPLICATIONPROFILETYPEL4 = 1,
        [EnumMember(Value = "APPLICATION_PROFILE_TYPE_HTTP")]
        APPLICATIONPROFILETYPEHTTP = 2,
        [EnumMember(Value = "APPLICATION_PROFILE_TYPE_SYSLOG")]
        APPLICATIONPROFILETYPESYSLOG = 3,
        [EnumMember(Value = "APPLICATION_PROFILE_TYPE_DNS")]
        APPLICATIONPROFILETYPEDNS = 4,
        [EnumMember(Value = "APPLICATION_PROFILE_TYPE_SSL")]
        APPLICATIONPROFILETYPESSL = 5,
        [EnumMember(Value = "APPLICATION_PROFILE_TYPE_SIP")]
        APPLICATIONPROFILETYPESIP = 6,
    }
}