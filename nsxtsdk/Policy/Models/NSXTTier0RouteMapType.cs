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
    public class NSXTTier0RouteMapType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Ordered list of route map entries.
        /// </summary>
        [JsonProperty(PropertyName = "entries", Required = Required.AllowNull)]
        public IList<NSXTRouteMapEntryType> Entries { get; set; }
    }
}
