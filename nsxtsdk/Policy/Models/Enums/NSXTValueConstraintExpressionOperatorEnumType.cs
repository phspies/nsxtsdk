// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Operation to check for value list for resource attribute of constraint.
    /// </summary>
    [NSXTProperty(Description: @"Operation to check for value list for resource attribute of constraint.")]
    public enum NSXTValueConstraintExpressionOperatorEnumType
    {
        [EnumMember(Value = "INCLUDES")]
        INCLUDES = 1,
        [EnumMember(Value = "EXCLUDES")]
        EXCLUDES = 2,
        [EnumMember(Value = "EQUALS")]
        EQUALS = 3,
    }
}
