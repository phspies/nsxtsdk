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
    /// Metadata fetched from an external system like Syslog or LogInsight.
    /// </summary>
    [NSXTProperty(Description: @"Metadata fetched from an external system like Syslog or LogInsight.")]
    public class NSXTErrorResolverSystemMetadataType 
    {
        /// <summary>
        /// The value fetched from another system
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
