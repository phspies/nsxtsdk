// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Set the request header with the value as indicated by thisSSL variable.Eg.send the whole certificate in PEM format.Enum options - HTTP_POLICY_VAR_CLIENT_IP,HTTP_POLICY_VAR_VS_PORT, HTTP_POLICY_VAR_VS_IP,HTTP_POLICY_VAR_HTTP_HDR,HTTP_POLICY_VAR_SSL_CLIENT_FINGERPRINT,HTTP_POLICY_VAR_SSL_CLIENT_SERIAL,HTTP_POLICY_VAR_SSL_CLIENT_ISSUER,HTTP_POLICY_VAR_SSL_CLIENT_SUBJECT,HTTP_POLICY_VAR_SSL_CLIENT_RAW,HTTP_POLICY_VAR_SSL_PROTOCOL,HTTP_POLICY_VAR_SSL_SERVER_NAME, HTTP_POLICY_VAR_USER_NAME,HTTP_POLICY_VAR_SSL_CIPHER, HTTP_POLICY_VAR_REQUEST_ID.
    /// </summary>
    [NSXTProperty(Description: @"Set the request header with the value as indicated by thisSSL variable.Eg.send the whole certificate in PEM format.Enum options - HTTP_POLICY_VAR_CLIENT_IP,HTTP_POLICY_VAR_VS_PORT, HTTP_POLICY_VAR_VS_IP,HTTP_POLICY_VAR_HTTP_HDR,HTTP_POLICY_VAR_SSL_CLIENT_FINGERPRINT,HTTP_POLICY_VAR_SSL_CLIENT_SERIAL,HTTP_POLICY_VAR_SSL_CLIENT_ISSUER,HTTP_POLICY_VAR_SSL_CLIENT_SUBJECT,HTTP_POLICY_VAR_SSL_CLIENT_RAW,HTTP_POLICY_VAR_SSL_PROTOCOL,HTTP_POLICY_VAR_SSL_SERVER_NAME, HTTP_POLICY_VAR_USER_NAME,HTTP_POLICY_VAR_SSL_CIPHER, HTTP_POLICY_VAR_REQUEST_ID.")]
    public enum NSXTAlbsslclientRequestHeaderRequestHeaderValueEnumType
    {
        [EnumMember(Value = "HTTP_POLICY_VAR_CLIENT_IP")]
        HTTPPOLICYVARCLIENTIP = 1,
        [EnumMember(Value = "HTTP_POLICY_VAR_VS_PORT")]
        HTTPPOLICYVARVSPORT = 2,
        [EnumMember(Value = "HTTP_POLICY_VAR_VS_IP")]
        HTTPPOLICYVARVSIP = 3,
        [EnumMember(Value = "HTTP_POLICY_VAR_HTTP_HDR")]
        HTTPPOLICYVARHTTPHDR = 4,
        [EnumMember(Value = "HTTP_POLICY_VAR_SSL_CLIENT_FINGERPRINT")]
        HTTPPOLICYVARSSLCLIENTFINGERPRINT = 5,
        [EnumMember(Value = "HTTP_POLICY_VAR_SSL_CLIENT_SERIAL")]
        HTTPPOLICYVARSSLCLIENTSERIAL = 6,
        [EnumMember(Value = "HTTP_POLICY_VAR_SSL_CLIENT_ISSUER")]
        HTTPPOLICYVARSSLCLIENTISSUER = 7,
        [EnumMember(Value = "HTTP_POLICY_VAR_SSL_CLIENT_SUBJECT")]
        HTTPPOLICYVARSSLCLIENTSUBJECT = 8,
        [EnumMember(Value = "HTTP_POLICY_VAR_SSL_CLIENT_RAW")]
        HTTPPOLICYVARSSLCLIENTRAW = 9,
        [EnumMember(Value = "HTTP_POLICY_VAR_SSL_PROTOCOL")]
        HTTPPOLICYVARSSLPROTOCOL = 10,
        [EnumMember(Value = "HTTP_POLICY_VAR_SSL_SERVER_NAME")]
        HTTPPOLICYVARSSLSERVERNAME = 11,
        [EnumMember(Value = "HTTP_POLICY_VAR_USER_NAME")]
        HTTPPOLICYVARUSERNAME = 12,
        [EnumMember(Value = "HTTP_POLICY_VAR_SSL_CIPHER")]
        HTTPPOLICYVARSSLCIPHER = 13,
        [EnumMember(Value = "HTTP_POLICY_VAR_REQUEST_ID")]
        HTTPPOLICYVARREQUESTID = 14,
    }
}