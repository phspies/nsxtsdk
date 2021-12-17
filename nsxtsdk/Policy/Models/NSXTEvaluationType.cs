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
    /// Criterion Evaluation is the basic logical condition to evaluate
        /// whether the event could be potentially met.
    /// </summary>
    [NSXTProperty(Description: @"Criterion Evaluation is the basic logical condition to evaluatewhether the event could be potentially met.")]
    public class NSXTEvaluationType 
    {
        public NSXTEvaluationType()
        {
        }
        /// <summary>
        /// Criterion Evaluation resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Criterion Evaluation resource type.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTEvaluationResourceTypeEnumType ResourceType { get; set; }
    }
}
