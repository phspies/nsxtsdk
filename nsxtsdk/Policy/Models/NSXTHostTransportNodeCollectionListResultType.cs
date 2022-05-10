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
    public class NSXTHostTransportNodeCollectionListResultType : NSXTListResultType
    {
        /// <summary>
        /// Transport Node collection results
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTHostTransportNodeCollectionType> Results { get; set; }
    }
}
