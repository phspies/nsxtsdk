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
    /// Tag operation status for particular resource type and resource ids.
    /// </summary>
    [NSXTProperty(Description: @"Tag operation status for particular resource type and resource ids.")]
    public class NSXTResourceTypeTagStatusType 
    {
        /// <summary>
        /// List of resources on which tag needs to be applied.
        /// </summary>
        [JsonProperty(PropertyName = "resource_tag_status")]
        public IList<NSXTResourceTagStatusType> ResourceTagStatus { get; set; }
        /// <summary>
        /// Resource type
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        public string ResourceType { get; set; }
    }
}
