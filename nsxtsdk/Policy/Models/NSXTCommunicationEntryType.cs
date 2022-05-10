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
    public class NSXTCommunicationEntryType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Define direction of traffic.
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTCommunicationEntryDirectionEnumType? Direction { get; set; }
        /// <summary>
        /// Text for additional notes on changes.
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public string? Notes { get; set; }
        /// <summary>
        /// Flag to enable packet logging. Default is disabled.
        /// </summary>
        [JsonProperty(PropertyName = "logged")]
        public bool? Logged { get; set; }
        /// <summary>
        /// Flag to disable the rule. Default is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "disabled")]
        public bool? Disabled { get; set; }
        /// <summary>
        /// In order to specify all services, use the constant "ANY".
        /// This is case insensitive. If "ANY" is used, it should
        /// be the ONLY element in the services array. Error will be thrown
        /// if ANY is used in conjunction with other values.
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        public IList<string> Services { get; set; }
        /// <summary>
        /// User level field which will be printed in CLI and packet logs.
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string? Tag { get; set; }
        /// <summary>
        /// We need paths as duplicate names may exist for groups under different
        /// domains.In order to specify all groups, use the constant "ANY". This
        /// is case insensitive. If "ANY" is used, it should be the ONLY element
        /// in the group array. Error will be thrown if ANY is used in conjunction
        /// with other values.
        /// </summary>
        [JsonProperty(PropertyName = "destination_groups")]
        public IList<string> DestinationGroups { get; set; }
        /// <summary>
        /// The action to be applied to all the services.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTCommunicationEntryActionEnumType? Action { get; set; }
        /// <summary>
        /// The list of policy paths where the communication entry is applied
        /// Edge/LR/T0/T1/LRP/CGW/MGW/etc. Note that a given rule can be applied
        /// on multiple LRs/LRPs.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public IList<string> Scope { get; set; }
        /// <summary>
        /// This field is used to resolve conflicts between multiple
        /// CommunicationEntries under CommunicationMap for a Domain
        /// If no sequence number is specified in the payload, a value of 0 is
        /// assigned by default. If there are multiple communication entries with
        /// the same sequence number then their order is not deterministic. If a
        /// specific order of communication entry is desired, then one has to
        /// specify unique sequence numbers or use the POST request on the
        /// communication entry entity with a query parameter action=revise to let
        /// the framework assign a sequence number
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number")]
        public int? SequenceNumber { get; set; }
        /// <summary>
        /// We need paths as duplicate names may exist for groups under different
        /// domains. In order to specify all groups, use the constant "ANY". This
        /// is case insensitive. If "ANY" is used, it should be the ONLY element
        /// in the group array. Error will be thrown if ANY is used in conjunction
        /// with other values.
        /// </summary>
        [JsonProperty(PropertyName = "source_groups")]
        public IList<string> SourceGroups { get; set; }
    }
}
