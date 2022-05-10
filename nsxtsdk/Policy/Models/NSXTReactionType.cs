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
    public class NSXTReactionType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Events that provide contextual variables about what the reaction should react to.
        /// This field can be interpreted as the WHAT of the Reaction, or simply as "If This"
        /// Clause.
        /// </summary>
        [JsonProperty(PropertyName = "events", Required = Required.AllowNull)]
        public IList<NSXTEventType> Events { get; set; }
        /// <summary>
        /// Actions that need to be taken when the events occur. These actions must appear
        /// in the order that they need to be taken in. This field can be interpreted as the
        /// HOW of the Reaction, or simply as "Then That".
        /// </summary>
        [JsonProperty(PropertyName = "actions", Required = Required.AllowNull)]
        public IList<NSXTActionType> Actions { get; set; }
    }
}
