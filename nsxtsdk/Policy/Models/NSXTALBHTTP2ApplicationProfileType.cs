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
    /// Advanced load balancer HTTP2ApplicationProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTP2ApplicationProfile object")]
    public class NSXTALBHTTP2ApplicationProfileType 
    {
        /// <summary>
        /// The maximum number of requests over a client side HTTP/2
        /// connection.
        /// Allowed values are 0-10000.
        /// Special values are 0- 'Unlimited requests on a client side
        /// HTTP/2 connection'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 1000.
        /// </summary>
        [JsonProperty(PropertyName = "max_http2_requests_per_connection")]
        public long? MaxHttp2RequestsPerConnection { get; set; }
        /// <summary>
        /// The max number of control frames that client can send over
        /// an HTTP/2 connection.
        /// '0' means unlimited.
        /// Allowed values are 0-10000.
        /// Special values are 0- 'Unlimited control frames on a client
        /// side HTTP/2 connection'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 1000.
        /// </summary>
        [JsonProperty(PropertyName = "max_http2_control_frames_per_connection")]
        public long? MaxHttp2ControlFramesPerConnection { get; set; }
        /// <summary>
        /// The max number of concurrent streams over a client side
        /// HTTP/2 connection.
        /// Allowed values are 1-256.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 128.
        /// </summary>
        [JsonProperty(PropertyName = "max_http2_concurrent_streams_per_connection")]
        public long? MaxHttp2ConcurrentStreamsPerConnection { get; set; }
        /// <summary>
        /// The max number of frames that can be queued waiting to be
        /// sent over a client side HTTP/2 connection at any given time.
        /// '0' means unlimited.
        /// Allowed values are 0-10000.
        /// Special values are 0- 'Unlimited frames can be queued on a
        /// client side HTTP/2 connection'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 1000.
        /// </summary>
        [JsonProperty(PropertyName = "max_http2_queued_frames_to_client_per_connection")]
        public long? MaxHttp2QueuedFramesToClientPerConnection { get; set; }
        /// <summary>
        /// The max number of empty data frames that client can send
        /// over an HTTP/2 connection.
        /// '0' means unlimited.
        /// Allowed values are 0-10000.
        /// Special values are 0- 'Unlimited empty data frames over a
        /// client side HTTP/2 connection'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 1000.
        /// </summary>
        [JsonProperty(PropertyName = "max_http2_empty_data_frames_per_connection")]
        public long? MaxHttp2EmptyDataFramesPerConnection { get; set; }
        /// <summary>
        /// The maximum size in bytes of the compressed request header
        /// field.
        /// The limit applies equally to both name and value.
        /// Allowed values are 1-8192.
        /// Unit is BYTES.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 4096.
        /// </summary>
        [JsonProperty(PropertyName = "max_http2_header_field_size")]
        public long? MaxHttp2HeaderFieldSize { get; set; }
        /// <summary>
        /// The initial flow control window size in KB for HTTP/2
        /// streams.
        /// Allowed values are 64-32768.
        /// Unit is KB.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 64.
        /// </summary>
        [JsonProperty(PropertyName = "http2_initial_window_size")]
        public long? Http2InitialWindowSize { get; set; }
    }
}
