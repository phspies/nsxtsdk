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
    public class NSXTCommunicationMapType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// CommunicationEntries that are a part of this CommunicationMap
        /// </summary>
        [JsonProperty(PropertyName = "communication_entries")]
        public IList<NSXTCommunicationEntryType> CommunicationEntries { get; set; }
        /// <summary>
        /// - Distributed Firewall -
        /// Policy framework for Distributed Firewall provides four pre-defined
        /// categories for classifying a communication map. They are
        /// "Emergency", "Infrastructure", "Environment" and "Application".
        /// Amongst the layer 3 communication maps,there is a pre-determined
        /// order in which the policy framework manages the priority of these
        /// communication maps. Emergency category has the highest priority
        /// followed by Infrastructure, Environment and then Application rules.
        /// Administrator can choose to categorize a communication  map into the
        /// above categories or can choose to leave it empty. If empty it will
        /// have the least precedence w.r.t the above four layer 3 categories.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string? Category { get; set; }
        /// <summary>
        /// This field is used to resolve conflicts between communication maps
        /// across domains. In order to change the precedence of a communication
        /// map one can fire a POST request on the communication map entity with
        /// a query parameter action=revise
        /// The precedence field will reflect the value of the computed precedence
        /// upon execution of the above mentioned POST request.
        /// For scenarios where the administrator is using a template to update
        /// several communication maps, the only way to set the precedence is to
        /// explicitly specify the precedence number for each communication map.
        /// If no precedence is specified in the payload, a value of 0 is
        /// assigned by default. If there are multiple communication maps with
        /// the same precedence then their order is not deterministic. If a
        /// specific order of communication map is desired, then one has to
        /// specify a unique precedence or use the POST request on the
        /// communication map entity with a query parameter action=revise to let
        /// the framework assign a precedence
        /// </summary>
        [JsonProperty(PropertyName = "precedence")]
        public int? Precedence { get; set; }
    }
}
