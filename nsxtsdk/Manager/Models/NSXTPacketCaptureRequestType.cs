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
    /// This type is used to create packet request on give node. Need to specify related parameters according to the capture
        /// point.
    /// </summary>
    [NSXTProperty(Description: @"This type is used to create packet request on give node. Need to specify related parameters according to the capture point.")]
    public class NSXTPacketCaptureRequestType 
    {
        /// <summary>
        /// Define the transport node to capture data.
        /// </summary>
        [JsonProperty(PropertyName = "node")]
        public string? Node { get; set; }
        /// <summary>
        /// Define the capture direction. Support three types INPUT/OUTPUT/DUAL.
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPacketCaptureRequestDirectionEnumType? Direction { get; set; }
        /// <summary>
        /// Define the packet capture duration time. After the capture duration time, the capture process will stop working.
        /// </summary>
        [JsonProperty(PropertyName = "capduration")]
        public int? Capduration { get; set; }
        /// <summary>
        /// Define the packet capture amount size.
        /// </summary>
        [JsonProperty(PropertyName = "capamount")]
        public int? Capamount { get; set; }
        /// <summary>
        /// This type is used to differenite the incoming request from CLI/UI.
        /// </summary>
        [JsonProperty(PropertyName = "capsource", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPacketCaptureRequestCapsourceEnumType Capsource { get; set; }
        /// <summary>
        /// Define the transport node to capture data.
        /// </summary>
        [JsonProperty(PropertyName = "node_ip")]
        public string? NodeIp { get; set; }
        /// <summary>
        /// Define the capture value of given capture point.
        /// </summary>
        [JsonProperty(PropertyName = "capvalue")]
        public string? Capvalue { get; set; }
        /// <summary>
        /// Define the capture filter type. Support PRE/POST mode.
        /// </summary>
        [JsonProperty(PropertyName = "filtertype")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPacketCaptureRequestFiltertypeEnumType? Filtertype { get; set; }
        /// <summary>
        /// Define the point to capture data.
        /// </summary>
        [JsonProperty(PropertyName = "cappoint", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPacketCaptureRequestCappointEnumType Cappoint { get; set; }
        /// <summary>
        /// Define the packet capture file size limit.
        /// </summary>
        [JsonProperty(PropertyName = "capfilesize")]
        public int? Capfilesize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public NSXTPacketCaptureOptionListType Options { get; set; }
        /// <summary>
        /// Set the stream port to receive the capture packet. The STREAM mode is based on GRE-in-UDP Encapsulation(RFC8086).
        /// Packets are sent to UDP port 4754.
        /// </summary>
        [JsonProperty(PropertyName = "streamport")]
        public int? Streamport { get; set; }
        /// <summary>
        /// Define the rate of packet capture process.
        /// </summary>
        [JsonProperty(PropertyName = "caprate")]
        public int? Caprate { get; set; }
        /// <summary>
        /// The CPU core id on Edge node.
        /// </summary>
        [JsonProperty(PropertyName = "capcore")]
        public int? Capcore { get; set; }
        /// <summary>
        /// Limit the number of bytes captured from each packet.
        /// </summary>
        [JsonProperty(PropertyName = "capsnaplen")]
        public int? Capsnaplen { get; set; }
        /// <summary>
        /// Set the stream address to receive the capture packet.
        /// </summary>
        [JsonProperty(PropertyName = "streamaddress")]
        public string? Streamaddress { get; set; }
        /// <summary>
        /// Define the capture streaming mode. The STREAM mode will send the data to given stream address and port. And the
        /// STANDALONE mode will save the capture file in local folder.
        /// </summary>
        [JsonProperty(PropertyName = "capmode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPacketCaptureRequestCapmodeEnumType? Capmode { get; set; }
    }
}
