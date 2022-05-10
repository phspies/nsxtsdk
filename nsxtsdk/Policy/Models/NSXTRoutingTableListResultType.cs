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
    public class NSXTRoutingTableListResultType : NSXTListResultType
    {
        /// <summary>
        /// Paged Collection of Routes per transport node ID.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTRoutingTableType> Results { get; set; }
    }
}
