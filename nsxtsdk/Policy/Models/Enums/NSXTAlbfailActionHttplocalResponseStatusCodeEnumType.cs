// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Enum options - FAIL_HTTP_STATUS_CODE_200,FAIL_HTTP_STATUS_CODE_503.Default value when not specified in API or module isinterpreted by ALB Controller as FAIL_HTTP_STATUS_CODE_503.
    /// </summary>
    [NSXTProperty(Description: @"Enum options - FAIL_HTTP_STATUS_CODE_200,FAIL_HTTP_STATUS_CODE_503.Default value when not specified in API or module isinterpreted by ALB Controller as FAIL_HTTP_STATUS_CODE_503.")]
    public enum NSXTAlbfailActionHttplocalResponseStatusCodeEnumType
    {
        [EnumMember(Value = "FAIL_HTTP_STATUS_CODE_200")]
        FAILHTTPSTATUSCODE200 = 1,
        [EnumMember(Value = "FAIL_HTTP_STATUS_CODE_503")]
        FAILHTTPSTATUSCODE503 = 0,
    }
}
