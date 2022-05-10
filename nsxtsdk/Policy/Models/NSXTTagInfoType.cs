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
    public class NSXTTagInfoType : NSXTTagType
    {
        /// <summary>
        /// Number of objects with assigned with matching scope and tag values
        /// </summary>
        [JsonProperty(PropertyName = "tagged_objects_count")]
        public int? TaggedObjectsCount { get; set; }
    }
}
