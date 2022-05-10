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
    public class NSXTIDSSummaryListResultType : NSXTListResultType
    {
        /// <summary>
        /// Paged collection of the detected intrusions.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTIDSEventsSummaryType> Results { get; set; }
    }
}
