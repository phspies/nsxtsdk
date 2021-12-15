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

namespace nsxtsdk.PolicyModels
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
        [NSXTProperty(IsRequired: false, Description: @"The value fetched from another system")]
        public string? Value { get; set; }
    }
}