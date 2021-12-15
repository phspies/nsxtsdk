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
    public class NSXTCommunicationEntryType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Define direction of traffic.
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        [NSXTProperty(IsRequired: false, Description: @"Define direction of traffic.")]
        [NSXTDefaultProperty(Default: "IN_OUT")]
        public NSXTCommunicationEntryDirectionEnumType? Direction { get; set; }
        /// <summary>
        /// Text for additional notes on changes.
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        [NSXTProperty(IsRequired: false, Description: @"Text for additional notes on changes.")]
        public string? Notes { get; set; }
        /// <summary>
        /// Flag to enable packet logging. Default is disabled.
        /// </summary>
        [JsonProperty(PropertyName = "logged")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to enable packet logging. Default is disabled.")]
        public bool? Logged { get; set; }
        /// <summary>
        /// Flag to disable the rule. Default is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "disabled")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to disable the rule. Default is enabled.")]
        public bool? Disabled { get; set; }
        /// <summary>
        /// In order to specify all services, use the constant "ANY".
        /// This is case insensitive. If "ANY" is used, it should
        /// be the ONLY element in the services array. Error will be thrown
        /// if ANY is used in conjunction with other values.
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        [NSXTProperty(IsRequired: false, Description: @"In order to specify all services, use the constant &quot;ANY&quot;.This is case insensitive. If &quot;ANY&quot; is used, it shouldbe the ONLY element in the services array. Error will be thrownif ANY is used in conjunction with other values.")]
        public IList<string> Services { get; set; }
        /// <summary>
        /// User level field which will be printed in CLI and packet logs.
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        [NSXTProperty(IsRequired: false, Description: @"User level field which will be printed in CLI and packet logs.")]
        public string? Tag { get; set; }
        /// <summary>
        /// We need paths as duplicate names may exist for groups under different
        /// domains.In order to specify all groups, use the constant "ANY". This
        /// is case insensitive. If "ANY" is used, it should be the ONLY element
        /// in the group array. Error will be thrown if ANY is used in conjunction
        /// with other values.
        /// </summary>
        [JsonProperty(PropertyName = "destination_groups")]
        [NSXTProperty(IsRequired: false, Description: @"We need paths as duplicate names may exist for groups under differentdomains.In order to specify all groups, use the constant &quot;ANY&quot;. Thisis case insensitive. If &quot;ANY&quot; is used, it should be the ONLY elementin the group array. Error will be thrown if ANY is used in conjunctionwith other values.")]
        public IList<string> DestinationGroups { get; set; }
        /// <summary>
        /// The action to be applied to all the services.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [NSXTProperty(IsRequired: false, Description: @"The action to be applied to all the services.")]
        public NSXTCommunicationEntryActionEnumType? Action { get; set; }
        /// <summary>
        /// The list of policy paths where the communication entry is applied
        /// Edge/LR/T0/T1/LRP/CGW/MGW/etc. Note that a given rule can be applied
        /// on multiple LRs/LRPs.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        [NSXTProperty(IsRequired: false, Description: @"The list of policy paths where the communication entry is appliedEdge/LR/T0/T1/LRP/CGW/MGW/etc. Note that a given rule can be appliedon multiple LRs/LRPs.")]
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
        [NSXTProperty(IsRequired: false, Description: @"This field is used to resolve conflicts between multipleCommunicationEntries under CommunicationMap for a DomainIf no sequence number is specified in the payload, a value of 0 isassigned by default. If there are multiple communication entries withthe same sequence number then their order is not deterministic. If aspecific order of communication entry is desired, then one has tospecify unique sequence numbers or use the POST request on thecommunication entry entity with a query parameter action=revise to letthe framework assign a sequence number")]
        public long? SequenceNumber { get; set; }
        /// <summary>
        /// We need paths as duplicate names may exist for groups under different
        /// domains. In order to specify all groups, use the constant "ANY". This
        /// is case insensitive. If "ANY" is used, it should be the ONLY element
        /// in the group array. Error will be thrown if ANY is used in conjunction
        /// with other values.
        /// </summary>
        [JsonProperty(PropertyName = "source_groups")]
        [NSXTProperty(IsRequired: false, Description: @"We need paths as duplicate names may exist for groups under differentdomains. In order to specify all groups, use the constant &quot;ANY&quot;. Thisis case insensitive. If &quot;ANY&quot; is used, it should be the ONLY elementin the group array. Error will be thrown if ANY is used in conjunctionwith other values.")]
        public IList<string> SourceGroups { get; set; }
    }
}