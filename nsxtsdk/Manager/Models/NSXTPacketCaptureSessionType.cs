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
    public class NSXTPacketCaptureSessionType : NSXTManagedResourceType
    {
        /// <summary>
        /// Packet capture session id.
        /// </summary>
        [JsonProperty(PropertyName = "sessionid", Required = Required.AllowNull)]
        public string Sessionid { get; set; }
        /// <summary>
        /// Packet capture file location.
        /// </summary>
        [JsonProperty(PropertyName = "filelocation")]
        public string? Filelocation { get; set; }
        /// <summary>
        /// Packet capture file Size in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "filesize")]
        public int? Filesize { get; set; }
        /// <summary>
        /// Packet capture session name.
        /// </summary>
        [JsonProperty(PropertyName = "sessionname")]
        public string? Sessionname { get; set; }
        /// <summary>
        /// Error messasge in capture.
        /// </summary>
        [JsonProperty(PropertyName = "errormsg")]
        public string? Errormsg { get; set; }
        /// <summary>
        /// Timestamp when session was stopped in epoch millisecond.
        /// </summary>
        [JsonProperty(PropertyName = "endtime")]
        public long? Endtime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "request", Required = Required.AllowNull)]
        public NSXTPacketCaptureRequestType Request { get; set; }
        /// <summary>
        /// Timestamp when session was created in epoch millisecond.
        /// </summary>
        [JsonProperty(PropertyName = "starttime")]
        public long? Starttime { get; set; }
        /// <summary>
        /// Packet capture session status.
        /// </summary>
        [JsonProperty(PropertyName = "sessionstatus", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPacketCaptureSessionSessionstatusEnumType Sessionstatus { get; set; }
    }
}
