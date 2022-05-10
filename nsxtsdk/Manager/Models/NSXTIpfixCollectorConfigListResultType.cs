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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIpfixCollectorConfigListResultType : NSXTListResultType
    {
        /// <summary>
        /// IPFIX Collector Config
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTIpfixCollectorConfigType> Results { get; set; }
    }
}
