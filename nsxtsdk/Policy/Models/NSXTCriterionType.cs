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
    /// Event Criterion is the logical evaluations by which the event may
        /// be deemed fulfilled. All the evaluations must be met in order for
        /// the criterion to be met (implicit AND).
    /// </summary>
    [NSXTProperty(Description: @"Event Criterion is the logical evaluations by which the event maybe deemed fulfilled. All the evaluations must be met in order forthe criterion to be met (implicit AND).")]
    public class NSXTCriterionType 
    {
        /// <summary>
        /// Criterion Evaluations.
        /// </summary>
        [JsonProperty(PropertyName = "evaluations", Required = Required.AllowNull)]
        public IList<NSXTEvaluationType> Evaluations { get; set; }
    }
}
