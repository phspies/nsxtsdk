// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Whether to apply Filter when group criteria is matched ornot.Enum options - IS_IN, IS_NOT_IN.Default value when not specified in API or module isinterpreted by ALB Controller as IS_IN.
    /// </summary>
    [NSXTProperty(Description: @"Whether to apply Filter when group criteria is matched ornot.Enum options - IS_IN, IS_NOT_IN.Default value when not specified in API or module isinterpreted by ALB Controller as IS_IN.")]
    public enum NSXTAlbcompressionFilterMatchEnumType
    {
        [EnumMember(Value = "IS_IN")]
        ISIN = 1,
        [EnumMember(Value = "IS_NOT_IN")]
        ISNOTIN = 2,
    }
}
