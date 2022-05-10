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
    public class NSXTEventListResultType : NSXTListResultType
    {
        /// <summary>
        /// List of events defined
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTMonitoringEventType> Results { get; set; }
    }
}
