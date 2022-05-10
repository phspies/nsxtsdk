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
    /// A link to a related resource
    /// </summary>
    [NSXTProperty(Description: @"A link to a related resource")]
    public class NSXTResourceLinkType 
    {
        /// <summary>
        /// Optional action
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string? Action { get; set; }
        /// <summary>
        /// Link to resource
        /// </summary>
        [JsonProperty(PropertyName = "href")]
        public string? Href { get; set; }
        /// <summary>
        /// Custom relation type (follows RFC 5988 where appropriate definitions exist)
        /// </summary>
        [JsonProperty(PropertyName = "rel")]
        public string? Rel { get; set; }
    }
}
