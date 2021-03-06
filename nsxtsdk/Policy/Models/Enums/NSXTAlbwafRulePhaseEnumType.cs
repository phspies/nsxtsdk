// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// The execution phase where this rule will be executed.Enum options - WAF_PHASE_CONNECTION,WAF_PHASE_REQUEST_HEADER, WAF_PHASE_REQUEST_BODY,WAF_PHASE_RESPONSE_HEADER, WAF_PHASE_RESPONSE_BODY,WAF_PHASE_LOGGING.
    /// </summary>
    [NSXTProperty(Description: @"The execution phase where this rule will be executed.Enum options - WAF_PHASE_CONNECTION,WAF_PHASE_REQUEST_HEADER, WAF_PHASE_REQUEST_BODY,WAF_PHASE_RESPONSE_HEADER, WAF_PHASE_RESPONSE_BODY,WAF_PHASE_LOGGING.")]
    public enum NSXTAlbwafRulePhaseEnumType
    {
        [EnumMember(Value = "WAF_PHASE_CONNECTION")]
        WAFPHASECONNECTION = 1,
        [EnumMember(Value = "WAF_PHASE_REQUEST_HEADER")]
        WAFPHASEREQUESTHEADER = 2,
        [EnumMember(Value = "WAF_PHASE_REQUEST_BODY")]
        WAFPHASEREQUESTBODY = 3,
        [EnumMember(Value = "WAF_PHASE_RESPONSE_HEADER")]
        WAFPHASERESPONSEHEADER = 4,
        [EnumMember(Value = "WAF_PHASE_RESPONSE_BODY")]
        WAFPHASERESPONSEBODY = 5,
        [EnumMember(Value = "WAF_PHASE_LOGGING")]
        WAFPHASELOGGING = 6,
    }
}
