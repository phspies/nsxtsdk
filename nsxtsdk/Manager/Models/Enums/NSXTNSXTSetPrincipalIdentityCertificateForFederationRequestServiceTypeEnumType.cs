// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Service type for which the certificate should be used.
    /// </summary>
    [NSXTProperty(Description: @"Service type for which the certificate should be used.")]
    public enum NSXTSetPrincipalIdentityCertificateForFederationRequestServiceTypeEnumType
    {
        [EnumMember(Value = "LOCAL_MANAGER")]
        LOCALMANAGER = 1,
        [EnumMember(Value = "GLOBAL_MANAGER")]
        GLOBALMANAGER = 2,
    }
}
