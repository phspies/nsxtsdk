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
    /// Resource attribute on which constraint should be applied.
        /// Example - sourceGroups attribute of Edge CommunicationEntry to be
        /// restricted, is given as:
        /// {
        /// "target_resource_type":"CommunicationEntry",
        /// "attribute":"sourceGroups",
        /// "path_prefix":"/infra/domains/vmc-domain/edge-communication-maps/default/communication-entries"
        /// }
    /// </summary>
    [NSXTProperty(Description: @"Resource attribute on which constraint should be applied.Example - sourceGroups attribute of Edge CommunicationEntry to be  restricted, is given as:  {     &quot;target_resource_type&quot;:&quot;CommunicationEntry&quot;,     &quot;attribute&quot;:&quot;sourceGroups&quot;,     &quot;path_prefix&quot;:&quot;/infra/domains/vmc-domain/edge-communication-maps/default/communication-entries&quot;  }")]
    public class NSXTConstraintTargetType 
    {
        /// <summary>
        /// Attribute name of the target entity.
        /// </summary>
        [JsonProperty(PropertyName = "attribute")]
        public string? Attribute { get; set; }
        /// <summary>
        /// Path prefix of the entity to apply constraint.
        /// This is required to further disambiguiate if multiple policy entities
        /// share the same resource type.
        /// Example - Edge FW and DFW use the same resource type CommunicationMap,
        /// CommunicationEntry, Group, etc.
        /// </summary>
        [JsonProperty(PropertyName = "path_prefix")]
        public string? PathPrefix { get; set; }
        /// <summary>
        /// Resource type of the target entity.
        /// </summary>
        [JsonProperty(PropertyName = "target_resource_type", Required = Required.AllowNull)]
        public string TargetResourceType { get; set; }
    }
}
