// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Set operation to constraint values.
    /// </summary>
    [NSXTProperty(Description: @"Set operation to constraint values.")]
    public enum NSXTConditionalValueConstraintExpressionOperatorEnumType
    {
        [EnumMember(Value = "INCLUDES")]
        INCLUDES = 1,
        [EnumMember(Value = "EXCLUDES")]
        EXCLUDES = 2,
        [EnumMember(Value = "EQUALS")]
        EQUALS = 3,
    }
}
