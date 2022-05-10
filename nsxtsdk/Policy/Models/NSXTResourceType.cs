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
    /// Base class for resources
    /// </summary>
    [NSXTProperty(Description: @"Base class for resources")]
    public class NSXTResourceType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "_self")]
        public NSXTSelfResourceLinkType Self { get; set; }
        /// <summary>
        /// The server will populate this field when returing the resource. Ignored on PUT and POST.
        /// </summary>
        [JsonProperty(PropertyName = "_links")]
        public IList<NSXTResourceLinkType> Links { get; set; }
        /// <summary>
        /// Schema for this resource
        /// </summary>
        [JsonProperty(PropertyName = "_schema")]
        public string? Schema { get; set; }
    }
}
