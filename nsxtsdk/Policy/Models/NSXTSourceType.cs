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
    /// Source that is logically deemed to be the "object" upon which the
        /// Event in question initially occurred upon. The Source is responsible
        /// for providing information of the occurred event. Some example sources
        /// include:
        /// - Resource.
        /// - API.
    /// </summary>
    [NSXTProperty(Description: @"Source that is logically deemed to be the &quot;object&quot; upon which theEvent in question initially occurred upon. The Source is responsiblefor providing information of the occurred event. Some example sourcesinclude:- Resource.- API.")]
    public class NSXTSourceType 
    {
        /// <summary>
        /// Event Source resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSourceResourceTypeEnumType ResourceType { get; set; }
    }
}
