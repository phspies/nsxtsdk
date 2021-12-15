// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// TACACS+ service.Enum options - AUTH_TACACS_PLUS_SERVICE_NONE,AUTH_TACACS_PLUS_SERVICE_LOGIN,AUTH_TACACS_PLUS_SERVICE_ENABLE,AUTH_TACACS_PLUS_SERVICE_PPP, AUTH_TACACS_PLUS_SERVICE_ARAP,AUTH_TACACS_PLUS_SERVICE_PT, AUTH_TACACS_PLUS_SERVICE_RCMD,AUTH_TACACS_PLUS_SERVICE_X25, AUTH_TACACS_PLUS_SERVICE_NASI,AUTH_TACACS_PLUS_SERVICE_FWPROXY.Default value when not specified in API or module isinterpreted by ALB Controller asAUTH_TACACS_PLUS_SERVICE_LOGIN.
    /// </summary>
    [NSXTProperty(Description: @"TACACS+ service.Enum options - AUTH_TACACS_PLUS_SERVICE_NONE,AUTH_TACACS_PLUS_SERVICE_LOGIN,AUTH_TACACS_PLUS_SERVICE_ENABLE,AUTH_TACACS_PLUS_SERVICE_PPP, AUTH_TACACS_PLUS_SERVICE_ARAP,AUTH_TACACS_PLUS_SERVICE_PT, AUTH_TACACS_PLUS_SERVICE_RCMD,AUTH_TACACS_PLUS_SERVICE_X25, AUTH_TACACS_PLUS_SERVICE_NASI,AUTH_TACACS_PLUS_SERVICE_FWPROXY.Default value when not specified in API or module isinterpreted by ALB Controller asAUTH_TACACS_PLUS_SERVICE_LOGIN.")]
    public enum NSXTAlbtacacsPlusAuthSettingsServiceEnumType
    {
        [EnumMember(Value = "AUTH_TACACS_PLUS_SERVICE_NONE")]
        AUTHTACACSPLUSSERVICENONE = 1,
        [EnumMember(Value = "AUTH_TACACS_PLUS_SERVICE_LOGIN")]
        AUTHTACACSPLUSSERVICELOGIN = 0,
        [EnumMember(Value = "AUTH_TACACS_PLUS_SERVICE_ENABLE")]
        AUTHTACACSPLUSSERVICEENABLE = 1,
        [EnumMember(Value = "AUTH_TACACS_PLUS_SERVICE_PPP")]
        AUTHTACACSPLUSSERVICEPPP = 2,
        [EnumMember(Value = "AUTH_TACACS_PLUS_SERVICE_ARAP")]
        AUTHTACACSPLUSSERVICEARAP = 3,
        [EnumMember(Value = "AUTH_TACACS_PLUS_SERVICE_PT")]
        AUTHTACACSPLUSSERVICEPT = 4,
        [EnumMember(Value = "AUTH_TACACS_PLUS_SERVICE_RCMD")]
        AUTHTACACSPLUSSERVICERCMD = 5,
        [EnumMember(Value = "AUTH_TACACS_PLUS_SERVICE_X25")]
        AUTHTACACSPLUSSERVICEX25 = 6,
        [EnumMember(Value = "AUTH_TACACS_PLUS_SERVICE_NASI")]
        AUTHTACACSPLUSSERVICENASI = 7,
        [EnumMember(Value = "AUTH_TACACS_PLUS_SERVICE_FWPROXY")]
        AUTHTACACSPLUSSERVICEFWPROXY = 8,
    }
}