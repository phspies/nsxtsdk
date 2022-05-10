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
    public class NSXTLbHttpProfileType : NSXTLbAppProfileType
    {
        /// <summary>
        /// When buffering is disabled, the response is passed to a client
        /// synchronously, immediately as it is received.
        /// When buffering is enabled, LB receives a response from the backend
        /// server as soon as possible, saving it into the buffers.
        /// </summary>
        [JsonProperty(PropertyName = "response_buffering")]
        public bool? ResponseBuffering { get; set; }
        /// <summary>
        /// If server doesn't send any packet within this time, the connection is closed.
        /// </summary>
        [JsonProperty(PropertyName = "response_timeout")]
        public long? ResponseTimeout { get; set; }
        /// <summary>
        /// If it is not specified, it means that request body size is unlimited.
        /// </summary>
        [JsonProperty(PropertyName = "request_body_size")]
        public long? RequestBodySize { get; set; }
        /// <summary>
        /// NTLM is an authentication protocol that can be used over HTTP. If the
        /// flag is set to true, LB will use NTLM challenge/response methodology.
        /// This property is deprecated. Please use the property server_keep_alive
        /// in order to keep the backend server connection alive for the client
        /// connection.
        /// When create a new profile, if both ntlm and server_keep_alive are set
        /// as different values, ERROR will be reported.
        /// When update an existing profile, if either ntlm or server_keep_alive
        /// value is changed, both of them are updated with the changed value.
        /// </summary>
        [JsonProperty(PropertyName = "ntlm")]
        public bool? Ntlm { get; set; }
        /// <summary>
        /// A request with header equal to or below this size is guaranteed to be
        /// processed. A request with header larger than request_header_size will
        /// be processed up to 32K bytes on best effort basis.
        /// </summary>
        [JsonProperty(PropertyName = "request_header_size")]
        public long? RequestHeaderSize { get; set; }
        /// <summary>
        /// Certain secure applications may want to force communication over SSL,
        /// but instead of rejecting non-SSL connections, they may choose to
        /// redirect the client automatically to use SSL.
        /// </summary>
        [JsonProperty(PropertyName = "http_redirect_to_https")]
        public bool? HttpRedirectToHttps { get; set; }
        /// <summary>
        /// A response with header larger than response_header_size will be dropped.
        /// </summary>
        [JsonProperty(PropertyName = "response_header_size")]
        public long? ResponseHeaderSize { get; set; }
        /// <summary>
        /// It is used to specify the HTTP application idle timeout, it means that
        /// how long the load balancer will keep the connection idle to wait for
        /// the client to send the next keep-alive request. It is not a TCP socket
        /// setting.
        /// </summary>
        [JsonProperty(PropertyName = "idle_timeout")]
        public long? IdleTimeout { get; set; }
        /// <summary>
        /// If server_keep_alive is true, it means the backend connection will keep
        /// alive for the client connection. Every client connection is tied 1:1
        /// with the corresponding server-side connection.
        /// If server_keep_alive is false, it means the backend connection won't
        /// keep alive for the client connection. The default value is false.
        /// If server_keep_alive is not specified for API input, its value in API
        /// output will be the same with the property ntlm.
        /// </summary>
        [JsonProperty(PropertyName = "server_keep_alive")]
        public bool? ServerKeepAlive { get; set; }
        /// <summary>
        /// If a website is temporarily down or has moved, incoming requests
        /// for that virtual server can be temporarily redirected to a URL
        /// </summary>
        [JsonProperty(PropertyName = "http_redirect_to")]
        public string? HttpRedirectTo { get; set; }
        /// <summary>
        /// When X-Forwareded-For is configured, X-Forwarded-Proto and
        /// X-Forwarded-Port information is added automatically. The two additional
        /// header information can be also modified or deleted in load balancer
        /// rules.
        /// </summary>
        [JsonProperty(PropertyName = "x_forwarded_for")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbHttpProfileXForwardedForEnumType? XForwardedFor { get; set; }
    }
}
