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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIdsClusterConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "cluster", Required = Required.AllowNull)]
        public NSXTPolicyResourceReferenceType Cluster { get; set; }
        /// <summary>
        /// If set to true, IDS is enabled on the respective cluster
        /// </summary>
        [JsonProperty(PropertyName = "ids_enabled", Required = Required.AllowNull)]
        public bool IdsEnabled { get; set; }
    }
}
