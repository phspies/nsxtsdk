// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Mode of dealing with the attacks - perform detection only,or detect and mitigate the attacks.Enum options - DETECTION, MITIGATION.Default value when not specified in API or module isinterpreted by ALB Controller as DETECTION.
    /// </summary>
    [NSXTProperty(Description: @"Mode of dealing with the attacks - perform detection only,or detect and mitigate the attacks.Enum options - DETECTION, MITIGATION.Default value when not specified in API or module isinterpreted by ALB Controller as DETECTION.")]
    public enum NSXTAlbsecurityPolicyOperModeEnumType
    {
        [EnumMember(Value = "DETECTION")]
        DETECTION = 1,
        [EnumMember(Value = "MITIGATION")]
        MITIGATION = 2,
    }
}
