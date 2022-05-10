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
    public class NSXTPacketCaptureSessionListType : NSXTListResultType
    {
        /// <summary>
        /// Packet capture list for all sessoins
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTPacketCaptureSessionType> Results { get; set; }
        /// <summary>
        /// Total capture session count
        /// </summary>
        [JsonProperty(PropertyName = "result_count", Required = Required.AllowNull)]
        public long ResultCount { get; set; }
    }
}
