// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Overall result of the probe. If the probe was able to connect to the LDAP service, authenticate using the provided credentials, and perform searches of the configured user and group search bases without error, the result is SUCCESS. Otherwise, the result is FAILURE, and additional details may be found in the errors property.
    /// </summary>
    [NSXTProperty(Description: @"Overall result of the probe. If the probe was able to connect to the LDAP service, authenticate using the provided credentials, and perform searches of the configured user and group search bases without error, the result is SUCCESS. Otherwise, the result is FAILURE, and additional details may be found in the errors property.")]
    public enum NSXTIdentitySourceLdapServerProbeResultResultEnumType
    {
        [EnumMember(Value = "SUCCESS")]
        SUCCESS = 1,
        [EnumMember(Value = "FAILURE")]
        FAILURE = 2,
    }
}