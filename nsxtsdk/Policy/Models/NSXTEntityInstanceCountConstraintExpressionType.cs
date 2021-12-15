// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTEntityInstanceCountConstraintExpressionType : NSXTConstraintExpressionType
    {
        /// <summary>
        /// Operations supported '<' and '<='.
        /// </summary>
        [JsonProperty(PropertyName = "operator", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Operations supported &apos;&lt;&apos; and &apos;&lt;=&apos;.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string OperatorProperty { get; set; }
        /// <summary>
        /// Instance count.
        /// </summary>
        [JsonProperty(PropertyName = "count", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Instance count.")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Count { get; set; }
    }
}
