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
    /// Criterion Evaluation is the basic logical condition to evaluate
        /// whether the event could be potentially met.
    /// </summary>
    [NSXTProperty(Description: @"Criterion Evaluation is the basic logical condition to evaluatewhether the event could be potentially met.")]
    public class NSXTEvaluationType 
    {
        /// <summary>
        /// Criterion Evaluation resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTEvaluationResourceTypeEnumType ResourceType { get; set; }
    }
}
