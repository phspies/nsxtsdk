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
    public class NSXTLiveTraceConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public NSXTLiveTraceFilterDataType Filter { get; set; }
        /// <summary>
        /// The duration for observing live traffic on the specified source logical port.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public long? Timeout { get; set; }
        /// <summary>
        /// Policy path of logical port to start a livetrace session.
        /// </summary>
        [JsonProperty(PropertyName = "src_port_path", Required = Required.AllowNull)]
        public string SrcPortPath { get; set; }
        /// <summary>
        /// This field indicates whether the intent is transient. If it is set to true, intent will be
        /// cleaned up after 1 hour of inactivity.
        /// </summary>
        [JsonProperty(PropertyName = "is_transient")]
        public bool? IsTransient { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "actions", Required = Required.AllowNull)]
        public NSXTPolicyLiveTraceActionConfigType Actions { get; set; }
    }
}
