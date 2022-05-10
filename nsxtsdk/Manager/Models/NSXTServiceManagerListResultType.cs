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
    public class NSXTServiceManagerListResultType : NSXTListResultType
    {
        /// <summary>
        /// List of the Service-managers.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTServiceManagerType> Results { get; set; }
    }
}
