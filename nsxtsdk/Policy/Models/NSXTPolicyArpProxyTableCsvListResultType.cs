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
    public class NSXTPolicyArpProxyTableCsvListResultType : NSXTCsvListResultType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTInterfaceArpProxyCsvEntryType> Results { get; set; }
    }
}
