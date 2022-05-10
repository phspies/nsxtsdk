using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTGroupType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Realization state of this group
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTGroupStateEnumType? State { get; set; }
        /// <summary>
        /// Extended Expression allows additional higher level context to be
        /// specified for grouping criteria. (e.g. user AD group)
        /// This field allow users to specified user context as the source of a
        /// firewall rule for IDFW feature.
        /// Current version only support a single IdentityGroupExpression. In the
        /// future, this might expand to support other conjunction and non-conjunction
        /// expression.
        /// 
        /// The extended expression list must follow below criteria:
        /// 1. Contains a single IdentityGroupExpression. No conjunction expression is
        /// supported.
        /// 2. No other non-conjunction expression is supported, except for
        /// IdentityGroupExpression.
        /// 3. Each expression must be a valid Expression. See the definition of
        /// the Expression type for more information.
        /// 4. Extended expression are implicitly AND with expression.
        /// 5. No nesting can be supported if this value is used.
        /// 6. If a Group is using extended expression, this group must be the only
        /// member in the source field of an communication map.
        /// </summary>
        [JsonProperty(PropertyName = "extended_expression")]
        public IList<NSXTExpressionType> ExtendedExpression { get; set; }
        /// <summary>
        /// The expression list must follow below criteria:
        /// 1. A non-empty expression list, must be of odd size. In a list, with
        /// indices starting from 0, all non-conjunction expressions must be at
        /// even indices, separated by a conjunction expression at odd
        /// indices.
        /// 2. The total of ConditionExpression and NestedExpression in a list
        /// should not exceed 5.
        /// 3. The total of IPAddressExpression, MACAddressExpression, external
        /// IDs in an ExternalIDExpression and paths in a PathExpression must not exceed
        /// 500.
        /// 4. Each expression must be a valid Expression. See the definition of
        /// the Expression type for more information.
        /// </summary>
        [JsonProperty(PropertyName = "expression")]
        public IList<NSXTExpressionType> Expression { get; set; }
        /// <summary>
        /// Group type can be specified during create and update of a group.
        /// Empty group type indicates a 'generic' group, ie group can
        /// include any entity from the valid GroupMemberType.
        /// </summary>
        [JsonProperty(PropertyName = "group_type")]
        public IList<string> GroupType { get; set; }
        /// <summary>
        /// If true, indicates that this is a remote reference group. Such group will have
        /// span different from the its parent domain. Default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "reference")]
        public bool? Reference { get; set; }
    }
}
