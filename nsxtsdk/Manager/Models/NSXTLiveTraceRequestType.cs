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
    public class NSXTLiveTraceRequestType : NSXTManagedResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public NSXTLiveTraceFilterDataType Filter { get; set; }
        /// <summary>
        /// Timeout in seconds for livetrace session
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public long? Timeout { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        public NSXTLiveTraceActionConfigType Actions { get; set; }
        /// <summary>
        /// Source logical port
        /// </summary>
        [JsonProperty(PropertyName = "source_lport")]
        public string? SourceLport { get; set; }
    }
}
