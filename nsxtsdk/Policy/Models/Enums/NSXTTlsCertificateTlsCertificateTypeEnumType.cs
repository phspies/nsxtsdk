// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Classification of the TlsCertificate helps differentiate how a TlsCertificate could beused for various components either as a client trust certificate; CERTIFICATE_CA, oras a server identity certificate; CERTIFICATE_SIGNED,or CERTIFICATE_SELF_SIGNED.
    /// </summary>
    [NSXTProperty(Description: @"Classification of the TlsCertificate helps differentiate how a TlsCertificate could beused for various components either as a client trust certificate; CERTIFICATE_CA, oras a server identity certificate; CERTIFICATE_SIGNED,or CERTIFICATE_SELF_SIGNED.")]
    public enum NSXTTlsCertificateTlsCertificateTypeEnumType
    {
        [EnumMember(Value = "CERTIFICATE_CA")]
        CERTIFICATECA = 1,
        [EnumMember(Value = "CERTIFICATE_SIGNED")]
        CERTIFICATESIGNED = 2,
        [EnumMember(Value = "CERTIFICATE_SELF_SIGNED")]
        CERTIFICATESELFSIGNED = 3,
    }
}