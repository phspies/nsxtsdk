// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Describes the alignment of legend. Alignment of a legend denotes how individual items of the legend are aligned in a container. For example, if VERTICAL is chosen then the items of the legend will appear one below the other and if HORIZONTAL is chosen then the items will appear side by side.
    /// </summary>
    [NSXTProperty(Description: @"Describes the alignment of legend. Alignment of a legend denotes how individual items of the legend are aligned in a container. For example, if VERTICAL is chosen then the items of the legend will appear one below the other and if HORIZONTAL is chosen then the items will appear side by side.")]
    public enum NSXTLegendAlignmentEnumType
    {
        [EnumMember(Value = "HORIZONTAL")]
        HORIZONTAL = 1,
        [EnumMember(Value = "VERTICAL")]
        VERTICAL = 0,
    }
}
