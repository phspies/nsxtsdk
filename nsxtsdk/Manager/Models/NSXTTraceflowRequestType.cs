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
    public class NSXTTraceflowRequestType : NSXTManagedResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "packet", Required = Required.AllowNull)]
        public NSXTPacketDataType Packet { get; set; }
        /// <summary>
        /// Maximum time (in ms) the management plane will wait for observation result list to be sent by controller plane. Upper
        /// limit for federation case is 90000, for non-federation case is 15000, the maximum is set to 90000 as the higher of the
        /// two cases.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public long? Timeout { get; set; }
        /// <summary>
        /// id of the source logical port to inject the traceflow packet into
        /// </summary>
        [JsonProperty(PropertyName = "lport_id", Required = Required.AllowNull)]
        public string LportId { get; set; }
    }
}
