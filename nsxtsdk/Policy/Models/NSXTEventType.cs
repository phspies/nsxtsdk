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
    /// The Event is the criterion or criteria applied to the source and,
        /// when met, prompt Policy to run the action.
        /// All Reaction Events are constructed with reference to
        /// the object, the "source", that is logically deemed to be the
        /// object upon which the Event in question initially occurred upon.
        /// Some example events include:
        /// - New object was created.
        /// - Change in realization state.
        /// - Specific API is called.
    /// </summary>
    [NSXTProperty(Description: @"The Event is the criterion or criteria applied to the source and,when met, prompt Policy to run the action.All Reaction Events are constructed with reference tothe object, the &quot;source&quot;, that is logically deemed to be theobject upon which the Event in question initially occurred upon.Some example events include:- New object was created.- Change in realization state.- Specific API is called.")]
    public class NSXTEventType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "source", Required = Required.AllowNull)]
        public NSXTSourceType Source { get; set; }
        /// <summary>
        /// Criteria applied to the source and, if satisfied, would trigger the
        /// action. Criteria is composed of criterions. In order for the Criteria
        /// to be met, only one of the criterion must be fulfilled (implicit OR).
        /// </summary>
        [JsonProperty(PropertyName = "criteria")]
        public IList<NSXTCriterionType> Criteria { get; set; }
    }
}
