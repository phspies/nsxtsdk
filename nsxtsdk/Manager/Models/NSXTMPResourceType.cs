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
    /// List of Manager Ids to migrate.
    /// </summary>
    [NSXTProperty(Description: @"List of Manager Ids to migrate.")]
    public class NSXTMPResourceType 
    {
        /// <summary>
        /// Manager and policy resource id array.
        /// </summary>
        [JsonProperty(PropertyName = "resource_ids", Required = Required.AllowNull)]
        public IList<NSXTMPResourceDetailsType> ResourceIds { get; set; }
        /// <summary>
        /// Manager resource type to migrate.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public string Type { get; set; }
    }
}
