// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Criteria for flow labelling.Enum options - NO_LABEL, APPLICATION_LABEL, SERVICE_LABEL.Default value when not specified in API or module isinterpreted by ALB Controller as NO_LABEL.
    /// </summary>
    [NSXTProperty(Description: @"Criteria for flow labelling.Enum options - NO_LABEL, APPLICATION_LABEL, SERVICE_LABEL.Default value when not specified in API or module isinterpreted by ALB Controller as NO_LABEL.")]
    public enum NSXTAlbvirtualServiceFlowLabelTypeEnumType
    {
        [EnumMember(Value = "NO_LABEL")]
        NOLABEL = 1,
        [EnumMember(Value = "APPLICATION_LABEL")]
        APPLICATIONLABEL = 2,
        [EnumMember(Value = "SERVICE_LABEL")]
        SERVICELABEL = 3,
    }
}
