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
    public class NSXTIdsProfileConjunctionOperatorType : NSXTIdsProfileCriteriaType
    {
        /// <summary>
        /// IDS Profile Filter Condition
        /// </summary>
        [JsonProperty(PropertyName = "operator", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIdsProfileConjunctionOperatorOperatorEnumType OperatorProperty { get; set; }
    }
}
