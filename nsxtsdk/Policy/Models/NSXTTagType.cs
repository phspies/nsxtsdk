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
    /// Arbitrary key-value pairs that may be attached to an entity
    /// </summary>
    [NSXTProperty(Description: @"Arbitrary key-value pairs that may be attached to an entity")]
    public class NSXTTagType 
    {
        /// <summary>
        /// Tag searches may optionally be restricted by scope
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string? Scope { get; set; }
        /// <summary>
        /// Identifier meaningful to user with maximum length of 256 characters
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string? Tag { get; set; }
    }
}
