// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// HTTP status code to use for local response when an policyrule is matched.Enum options - HTTP_RESPONSE_STATUS_CODE_401,HTTP_RESPONSE_STATUS_CODE_403.
    /// </summary>
    [NSXTProperty(Description: @"HTTP status code to use for local response when an policyrule is matched.Enum options - HTTP_RESPONSE_STATUS_CODE_401,HTTP_RESPONSE_STATUS_CODE_403.")]
    public enum NSXTAlbauthorizationActionStatusCodeEnumType
    {
        [EnumMember(Value = "HTTP_RESPONSE_STATUS_CODE_401")]
        HTTPRESPONSESTATUSCODE401 = 1,
        [EnumMember(Value = "HTTP_RESPONSE_STATUS_CODE_403")]
        HTTPRESPONSESTATUSCODE403 = 2,
    }
}