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
    public class NSXTPolicyArpProxyTableListResultType : NSXTListResultType
    {
        /// <summary>
        /// Paginated list of Gateway interface ARP proxy tables
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTInterfaceArpProxyType> Results { get; set; }
    }
}
