// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// WAF Policy mode.This can be detection or enforcement.It can be overwritten by rules if allow_mode_delegation isset.Enum options - WAF_MODE_DETECTION_ONLY,WAF_MODE_ENFORCEMENT.Default value when not specified in API or module isinterpreted by ALB Controller as WAF_MODE_DETECTION_ONLY.
    /// </summary>
    [NSXTProperty(Description: @"WAF Policy mode.This can be detection or enforcement.It can be overwritten by rules if allow_mode_delegation isset.Enum options - WAF_MODE_DETECTION_ONLY,WAF_MODE_ENFORCEMENT.Default value when not specified in API or module isinterpreted by ALB Controller as WAF_MODE_DETECTION_ONLY.")]
    public enum NSXTAlbwafPolicyModeEnumType
    {
        [EnumMember(Value = "WAF_MODE_DETECTION_ONLY")]
        WAFMODEDETECTIONONLY = 1,
        [EnumMember(Value = "WAF_MODE_ENFORCEMENT")]
        WAFMODEENFORCEMENT = 2,
    }
}
