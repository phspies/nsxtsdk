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
    /// Information about linked resource.
    /// </summary>
    [NSXTProperty(Description: @"Information about linked resource.")]
    public class NSXTMPResourceLinkedDetailsType 
    {
        /// <summary>
        /// Resource id of the assocationed resource.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
        /// <summary>
        /// Associated resource type.
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        public string Key { get; set; }
    }
}
