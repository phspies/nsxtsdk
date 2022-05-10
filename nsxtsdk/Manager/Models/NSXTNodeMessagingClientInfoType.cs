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
    public class NSXTNodeMessagingClientInfoType 
    {
        /// <summary>
        /// A list of messaging clients owned by this entity
        /// </summary>
        [JsonProperty(PropertyName = "clients")]
        public IList<NSXTMessagingClientInfoType> Clients { get; set; }
        /// <summary>
        /// Entity type of this messaging client
        /// </summary>
        [JsonProperty(PropertyName = "entity_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeMessagingClientInfoEntityTypeEnumType? EntityType { get; set; }
    }
}
