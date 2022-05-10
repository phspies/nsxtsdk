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
    public class NSXTLbPassiveMonitorType : NSXTLbMonitorType
    {
        /// <summary>
        /// When the consecutive failures reach this value, then the member is
        /// considered temporarily unavailable for a configurable period
        /// </summary>
        [JsonProperty(PropertyName = "max_fails")]
        public long? MaxFails { get; set; }
        /// <summary>
        /// After this timeout period, the member is tried again for a new
        /// connection to see if it is available.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public long? Timeout { get; set; }
    }
}
