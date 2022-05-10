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
    public class NSXTSearchResponseType : NSXTListResultType
    {
        /// <summary>
        /// List of records matching the search query.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<object> Results { get; set; }
    }
}
