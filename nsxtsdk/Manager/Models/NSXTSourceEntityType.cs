using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Service insertion data path inserts unique 'source node id' value into each packet before it received by Service VM.
        /// This value can be resolved to multiple Source Entities. It represents source of the packets.
    /// </summary>
    [NSXTProperty(Description: @"Service insertion data path inserts unique &apos;source node id&apos; value into each packet before it received by Service VM. This value can be resolved to multiple Source Entities. It represents source of the packets.")]
    public class NSXTSourceEntityType 
    {
        /// <summary>
        /// Type of source entity. Currently source value can be resolved to VIF and Virtual Machine.
        /// </summary>
        [JsonProperty(PropertyName = "source_entity_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSourceEntitySourceEntityTypeEnumType? SourceEntityType { get; set; }
        /// <summary>
        /// UUID of Source entity
        /// </summary>
        [JsonProperty(PropertyName = "source_entity_id")]
        public string? SourceEntityId { get; set; }
    }
}
