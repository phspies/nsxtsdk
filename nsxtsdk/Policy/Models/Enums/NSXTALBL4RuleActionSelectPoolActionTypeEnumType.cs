// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Indicates action to take on rule match.Enum options - L4_RULE_ACTION_SELECT_POOL,L4_RULE_ACTION_SELECT_POOLGROUP.Allowed in Basic(Allowed values-L4_RULE_ACTION_SELECT_POOL) edition, Essentials(Allowedvalues- L4_RULE_ACTION_SELECT_POOL) edition, Enterpriseedition.
    /// </summary>
    [NSXTProperty(Description: @"Indicates action to take on rule match.Enum options - L4_RULE_ACTION_SELECT_POOL,L4_RULE_ACTION_SELECT_POOLGROUP.Allowed in Basic(Allowed values-L4_RULE_ACTION_SELECT_POOL) edition, Essentials(Allowedvalues- L4_RULE_ACTION_SELECT_POOL) edition, Enterpriseedition.")]
    public enum NSXTALBL4RuleActionSelectPoolActionTypeEnumType
    {
        [EnumMember(Value = "L4_RULE_ACTION_SELECT_POOL")]
        L4RULEACTIONSELECTPOOL = 1,
        [EnumMember(Value = "L4_RULE_ACTION_SELECT_POOLGROUP")]
        L4RULEACTIONSELECTPOOLGROUP = 2,
    }
}
