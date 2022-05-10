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
    /// Port Connection Entity
    /// </summary>
    [NSXTProperty(Description: @"Port Connection Entity")]
    public class NSXTPortConnectionEntityType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public NSXTManagedResourceType Resource { get; set; }
        /// <summary>
        /// Resource ID is mapped to this. (ID is Generated for Edge node groups, since resource will be null)
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
    }
}
