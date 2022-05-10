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
    public class NSXTPolicyIdsIpListType : NSXTListResultType
    {
        /// <summary>
        /// List of all affected IP addresses specific to a particular signature.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<string> Results { get; set; }
    }
}
