// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public enum NSXTConstraintExpressionResourceTypeEnumType
    {
        [EnumMember(Value = "VALUECONSTRAINTEXPRESSION")]
        ValueConstraintExpression = 1,
        [EnumMember(Value = "RELATEDATTRIBUTECONDITIONALEXPRESSION")]
        RelatedAttributeConditionalExpression = 2,
        [EnumMember(Value = "ENTITYINSTANCECOUNTCONSTRAINTEXPRESSION")]
        EntityInstanceCountConstraintExpression = 3,
        [EnumMember(Value = "FIELDSANITYCONSTRAINTEXPRESSION")]
        FieldSanityConstraintExpression = 4,
    }
}
