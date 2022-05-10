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
    /// Section query parameters
    /// </summary>
    [NSXTProperty(Description: @"Section query parameters")]
    public class NSXTDSSectionQueryParametersType 
    {
        /// <summary>
        /// Flag to cascade delete of this object to all it's child objects.
        /// </summary>
        [JsonProperty(PropertyName = "cascade")]
        public bool? Cascade { get; set; }
    }
}
