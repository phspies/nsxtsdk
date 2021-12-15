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
        [NSXTProperty(IsRequired: false, Description: @"Unique identifier of entity")]
        public string? EntityUuid { get; set; }
        /// <summary>
        /// The type of entity hosted could be MP, CCP, VMC App etc.
        /// </summary>
        [JsonProperty(PropertyName = "entity_type")]
        [NSXTProperty(IsRequired: false, Description: @"The type of entity hosted could be MP, CCP, VMC App etc.")]
        public string? EntityType { get; set; }
    }
}
