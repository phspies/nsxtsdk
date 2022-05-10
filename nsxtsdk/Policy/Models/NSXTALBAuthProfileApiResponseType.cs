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
    public class NSXTALBAuthProfileApiResponseType : NSXTListResultType
    {
        /// <summary>
        /// count
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }
        /// <summary>
        /// Array of AuthProfile
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTALBAuthProfileType> Results { get; set; }
    }
}
