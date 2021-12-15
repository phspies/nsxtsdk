// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Type of port attachment. STATIC is added to replace INDEPENDENT. INDEPENDENT type and PARENT type are deprecated.
    /// </summary>
    [NSXTProperty(Description: @"Type of port attachment. STATIC is added to replace INDEPENDENT. INDEPENDENT type and PARENT type are deprecated.")]
    public enum NSXTPortAttachmentTypeEnumType
    {
        [EnumMember(Value = "PARENT")]
        PARENT = 1,
        [EnumMember(Value = "CHILD")]
        CHILD = 2,
        [EnumMember(Value = "INDEPENDENT")]
        INDEPENDENT = 3,
        [EnumMember(Value = "STATIC")]
        STATIC = 4,
    }
}