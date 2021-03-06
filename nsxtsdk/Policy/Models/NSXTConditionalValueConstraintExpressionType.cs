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
    /// Represents the leaf level expression to restrict the target attribute value
        /// based on the set of existing values. Generally, used in combination with
        /// RelatedAttributeConditionalExpression to constraint the values related to
        /// another attribute on the same resource. This object is always used in
        /// conjunction with some exression.
        /// Example -
        /// {
        /// "condition" : {
        /// "operator":"INCLUDES",
        /// "rhs_value": ["/infra/domains/mgw/groups/VCENTER", "/infra/domains/mgw/groups/SRM", "/infra/domains/mgw/groups/NSX"],
        /// "value_constraint": {
        /// "resource_type": "ValueConstraintExpression",
        /// "operator":"EXCLUDES",
        /// "values":["/infra/domains/mgw/groups/VCENTER", "/infra/domains/mgw/groups/SRM", "/infra/domains/mgw/groups/NSX"]
        /// }
        /// }
    /// </summary>
    [NSXTProperty(Description: @"Represents the leaf level expression to restrict the target attribute valuebased on the set of existing values. Generally, used in combination withRelatedAttributeConditionalExpression to constraint the values related toanother attribute on the same resource. This object is always used inconjunction with some exression.Example -{  &quot;condition&quot; : {      &quot;operator&quot;:&quot;INCLUDES&quot;,      &quot;rhs_value&quot;: [&quot;/infra/domains/mgw/groups/VCENTER&quot;, &quot;/infra/domains/mgw/groups/SRM&quot;, &quot;/infra/domains/mgw/groups/NSX&quot;],      &quot;value_constraint&quot;: {          &quot;resource_type&quot;: &quot;ValueConstraintExpression&quot;,          &quot;operator&quot;:&quot;EXCLUDES&quot;,          &quot;values&quot;:[&quot;/infra/domains/mgw/groups/VCENTER&quot;, &quot;/infra/domains/mgw/groups/SRM&quot;, &quot;/infra/domains/mgw/groups/NSX&quot;]  }}")]
    public class NSXTConditionalValueConstraintExpressionType 
    {
        /// <summary>
        /// Set operation to constraint values.
        /// </summary>
        [JsonProperty(PropertyName = "operator", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTConditionalValueConstraintExpressionOperatorEnumType OperatorProperty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "value_constraint", Required = Required.AllowNull)]
        public NSXTValueConstraintExpressionType ValueConstraint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rhs_value_with_type")]
        public NSXTConstraintValueType RhsValueWithType { get; set; }
        /// <summary>
        /// List of values.
        /// </summary>
        [JsonProperty(PropertyName = "rhs_value")]
        public IList<string> RhsValue { get; set; }
    }
}
