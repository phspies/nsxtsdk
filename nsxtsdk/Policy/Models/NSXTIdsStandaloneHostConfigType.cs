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
    public class NSXTIdsStandaloneHostConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// If set to true, IDS is enabled on standalone hosts.
        /// </summary>
        [JsonProperty(PropertyName = "ids_enabled", Required = Required.AllowNull)]
        public bool IdsEnabled { get; set; }
    }
}
