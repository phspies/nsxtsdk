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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTHostedEntityInfoType 
    {
        /// <summary>
        /// Unique identifier of entity
        /// </summary>
        [JsonProperty(PropertyName = "entity_uuid")]
        public string? EntityUuid { get; set; }
        /// <summary>
        /// The type of entity hosted could be MP, CCP, VMC App etc.
        /// </summary>
        [JsonProperty(PropertyName = "entity_type")]
        public string? EntityType { get; set; }
    }
}
