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
    /// Advanced load balancer HTTPApplicationProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPApplicationProfile object")]
    public class NSXTALBHTTPApplicationProfileType 
    {
        /// <summary>
        /// Enable chunk body merge for chunked transfer encoding
        /// response.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "enable_chunk_merge")]
        public bool? EnableChunkMerge { get; set; }
        /// <summary>
        /// The max number of HTTP requests that can be sent over a
        /// Keep-Alive connection.
        /// '0' means unlimited.
        /// Allowed values are 0-1000000.
        /// Special values are 0- 'Unlimited requests on a connection'.
        /// Allowed in Basic(Allowed values- 100) edition,
        /// Essentials(Allowed values- 100) edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 100.
        /// </summary>
        [JsonProperty(PropertyName = "max_keepalive_requests")]
        public long? MaxKeepaliveRequests { get; set; }
        /// <summary>
        /// Maximum requests per second per URI.
        /// Allowed values are 10-1000.
        /// Special values are 0- 'unlimited'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "max_rps_uri")]
        public long? MaxRpsUri { get; set; }
        /// <summary>
        /// Forward the Connection  Close header coming from backend
        /// server to the client if connection-switching is enabled,
        /// i.e.
        /// front-end and backend connections are bound together.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "fwd_close_hdr_for_bound_connections")]
        public bool? FwdCloseHdrForBoundConnections { get; set; }
        /// <summary>
        /// Send HTTP 'Keep-Alive' header to the client.
        /// By default, the timeout specified in the 'Keep-Alive
        /// Timeout' field will be used unless the 'Use App Keepalive
        /// Timeout' flag is set, in which case the timeout sent by the
        /// application will be honored.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "keepalive_header")]
        public bool? KeepaliveHeader { get; set; }
        /// <summary>
        /// Maximum requests per second per client IP and URI.
        /// Allowed values are 10-1000.
        /// Special values are 0- 'unlimited'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "max_rps_cip_uri")]
        public long? MaxRpsCipUri { get; set; }
        /// <summary>
        /// Insert an X-Forwarded-Proto header in the request sent to
        /// the server.
        /// When the client connects via SSL, Avi terminates the SSL,
        /// and then forwards the requests to the servers via HTTP, so
        /// the servers can determine the original protocol via this
        /// header.
        /// In this example, the value will be 'https'.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "x_forwarded_proto_enabled")]
        public bool? XForwardedProtoEnabled { get; set; }
        /// <summary>
        /// Allows HTTP requests, not just TCP connections, to be load
        /// balanced across servers.
        /// Proxied TCP connections to servers may be reused by
        /// multiple clients to improve performance.
        /// Not compatible with Preserve Client IP.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "connection_multiplexing_enabled")]
        public bool? ConnectionMultiplexingEnabled { get; set; }
        /// <summary>
        /// Enable Websockets proxy for traffic from clients to the
        /// virtual service.
        /// Connections to this VS start in HTTP mode.
        /// If the client requests an Upgrade to Websockets, and the
        /// server responds back with success, then the connection is
        /// upgraded to WebSockets mode.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "websockets_enabled")]
        public bool? WebsocketsEnabled { get; set; }
        /// <summary>
        /// Enable HTTP request body metrics.
        /// If enabled, requests from clients are parsed and relevant
        /// statistics about them are gathered.
        /// Currently, it processes HTTP POST requests with
        /// Content-Type application/x-www-form-urlencoded or
        /// multipart/form-data, and adds the number of detected
        /// parameters to the l7_client.http_params_count.
        /// This is an experimental feature and it may have performance
        /// impact.
        /// Use it when detailed information about the number of HTTP
        /// POST parameters is needed, e.g.
        /// for WAF sizing.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enable_request_body_metrics")]
        public bool? EnableRequestBodyMetrics { get; set; }
        /// <summary>
        /// Enable request body buffering for POST requests.
        /// If enabled, max buffer size is set to lower of 32M or the
        /// value (non-zero) configured in client_max_body_size.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enable_request_body_buffering")]
        public bool? EnableRequestBodyBuffering { get; set; }
        /// <summary>
        /// Inserts HTTP Strict-Transport-Security header in the HTTPS
        /// response.
        /// HSTS can help mitigate man-in-the-middle attacks by telling
        /// browsers that support HSTS that they should only access this
        /// site via HTTPS.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "hsts_enabled")]
        public bool? HstsEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "compression_profile")]
        public NSXTALBCompressionProfileType CompressionProfile { get; set; }
        /// <summary>
        /// The client's original IP address is inserted into an HTTP
        /// request header sent to the server.
        /// Servers may use this address for logging or other purposes,
        /// rather than Avi's source NAT address used in the Avi to
        /// server IP connection.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "xff_enabled")]
        public bool? XffEnabled { get; set; }
        /// <summary>
        /// If enabled, an HTTP request on an SSL port will result in
        /// connection close instead of a 400 response.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "reset_conn_http_on_ssl_port")]
        public bool? ResetConnHttpOnSslPort { get; set; }
        /// <summary>
        /// Number of days for which the client should regard this
        /// virtual service as a known HSTS host.
        /// Allowed values are 0-10000.
        /// Allowed in Basic(Allowed values- 365) edition,
        /// Essentials(Allowed values- 365) edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 365.
        /// </summary>
        [JsonProperty(PropertyName = "hsts_max_age")]
        public long? HstsMaxAge { get; set; }
        /// <summary>
        /// The max idle time allowed between HTTP requests over a
        /// Keep-alive connection.
        /// Allowed values are 10-100000000.
        /// Unit is MILLISECONDS.
        /// Allowed in Essentials(Allowed values- 30000) edition,
        /// Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 30000.
        /// </summary>
        [JsonProperty(PropertyName = "keepalive_timeout")]
        public long? KeepaliveTimeout { get; set; }
        /// <summary>
        /// Specifies whether the client side verification is set to
        /// none, request or require.
        /// Enum options - SSL_CLIENT_CERTIFICATE_NONE,
        /// SSL_CLIENT_CERTIFICATE_REQUEST,
        /// SSL_CLIENT_CERTIFICATE_REQUIRE.
        /// Allowed in Basic(Allowed values-
        /// SSL_CLIENT_CERTIFICATE_NONE,SSL_CLIENT_CERTIFICATE_REQUIRE)
        /// edition, Essentials(Allowed values-
        /// SSL_CLIENT_CERTIFICATE_NONE,SSL_CLIENT_CERTIFICATE_REQUIRE)
        /// edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// SSL_CLIENT_CERTIFICATE_NONE.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_client_certificate_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhttpapplicationProfileSslClientCertificateModeEnumType? SslClientCertificateMode { get; set; }
        /// <summary>
        /// When terminating client SSL sessions at Avi, servers may
        /// incorrectly send redirect to clients as HTTP.
        /// This option will rewrite the server's redirect responses
        /// for this virtual service from HTTP to HTTPS.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "server_side_redirect_to_https")]
        public bool? ServerSideRedirectToHttps { get; set; }
        /// <summary>
        /// Disable strict check between TLS servername and HTTP Host
        /// name.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "disable_sni_hostname_check")]
        public bool? DisableSniHostnameCheck { get; set; }
        /// <summary>
        /// Avi will respond with 100-Continue response if Expect
        /// 100-Continue header received from client.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "respond_with_100_continue")]
        public bool? RespondWith100Continue { get; set; }
        /// <summary>
        /// Maximum bad requests per second per client IP and URI.
        /// Allowed values are 10-1000.
        /// Special values are 0- 'unlimited'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "max_bad_rps_cip_uri")]
        public long? MaxBadRpsCipUri { get; set; }
        /// <summary>
        /// The maximum length of time allowed between consecutive read
        /// operations for a client request body.
        /// The value '0' specifies no timeout.
        /// This setting generally impacts the length of time allowed
        /// for a client to send a POST.
        /// Allowed values are 0-100000000.
        /// Unit is MILLISECONDS.
        /// Allowed in Basic(Allowed values- 30000) edition,
        /// Essentials(Allowed values- 30000) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 30000.
        /// </summary>
        [JsonProperty(PropertyName = "client_body_timeout")]
        public long? ClientBodyTimeout { get; set; }
        /// <summary>
        /// Mark HTTP cookies as HTTPonly.
        /// This helps mitigate cross site scripting attacks as
        /// browsers will not allow these cookies to be read by third
        /// parties, such as javascript.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "httponly_enabled")]
        public bool? HttponlyEnabled { get; set; }
        /// <summary>
        /// Disable keep-alive client side connections for older
        /// browsers based off MS Internet Explorer 6.0 (MSIE6).
        /// For some applications, this might break NTLM authentication
        /// for older clients based off MSIE6.
        /// For such applications, set this option to false to allow
        /// keep-alive connections.
        /// Allowed in Basic(Allowed values- true) edition,
        /// Essentials(Allowed values- true) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "disable_keepalive_posts_msie6")]
        public bool? DisableKeepalivePostsMsie6 { get; set; }
        /// <summary>
        /// Maximum size in Kbytes of a single HTTP header in the
        /// client request.
        /// Allowed values are 1-64.
        /// Unit is KB.
        /// Allowed in Basic(Allowed values- 12) edition,
        /// Essentials(Allowed values- 12) edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 12.
        /// </summary>
        [JsonProperty(PropertyName = "client_max_header_size")]
        public long? ClientMaxHeaderSize { get; set; }
        /// <summary>
        /// Client requests received via HTTP will be redirected to
        /// HTTPS.
        /// Allowed in Essentials(Allowed values- false) edition,
        /// Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "http_to_https")]
        public bool? HttpToHttps { get; set; }
        /// <summary>
        /// Maximum bad requests per second per client IP.
        /// Allowed values are 10-1000.
        /// Special values are 0- 'unlimited'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "max_bad_rps_cip")]
        public long? MaxBadRpsCip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ssl_client_certificate_action")]
        public NSXTALBSSLClientCertificateActionType SslClientCertificateAction { get; set; }
        /// <summary>
        /// Maximum size in Kbytes of all the client HTTP request
        /// headers.
        /// Allowed values are 1-256.
        /// Unit is KB.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 48.
        /// </summary>
        [JsonProperty(PropertyName = "client_max_request_size")]
        public long? ClientMaxRequestSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "cache_config")]
        public NSXTALBHttpCacheConfigType CacheConfig { get; set; }
        /// <summary>
        /// Maximum unknown URIs per second.
        /// Allowed values are 10-1000.
        /// Special values are 0- 'unlimited'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "max_rps_unknown_uri")]
        public long? MaxRpsUnknownUri { get; set; }
        /// <summary>
        /// Insert the 'includeSubdomains' directive in the HTTP
        /// Strict-Transport-Security header.
        /// Adding the includeSubdomains directive signals the
        /// User-Agent that the HSTS Policy applies to this HSTS Host as
        /// well as any subdomains of the host's domain name.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Special default for Basic edition is false, Essentials
        /// edition is false, Enterprise is True.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "hsts_subdomains_enabled")]
        public bool? HstsSubdomainsEnabled { get; set; }
        /// <summary>
        /// Size of HTTP buffer in kB.
        /// Allowed values are 1-256.
        /// Special values are 0- 'Auto compute the size of buffer'.
        /// Unit is KB.
        /// Allowed in Basic(Allowed values- 0) edition,
        /// Essentials(Allowed values- 0) edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "http_upstream_buffer_size")]
        public long? HttpUpstreamBufferSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "http2_profile")]
        public NSXTALBHTTP2ApplicationProfileType Http2Profile { get; set; }
        /// <summary>
        /// The max allowed length of time between a client
        /// establishing a TCP connection and Avi receives the first
        /// byte of the client's HTTP request.
        /// Allowed values are 10-100000000.
        /// Unit is MILLISECONDS.
        /// Allowed in Basic(Allowed values- 30000) edition,
        /// Essentials(Allowed values- 30000) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 30000.
        /// </summary>
        [JsonProperty(PropertyName = "post_accept_timeout")]
        public long? PostAcceptTimeout { get; set; }
        /// <summary>
        /// The maximum length of time allowed for a client to transmit
        /// an entire request header.
        /// This helps mitigate various forms of SlowLoris attacks.
        /// Allowed values are 10-100000000.
        /// Unit is MILLISECONDS.
        /// Allowed in Basic(Allowed values- 10000) edition,
        /// Essentials(Allowed values- 10000) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 10000.
        /// </summary>
        [JsonProperty(PropertyName = "client_header_timeout")]
        public long? ClientHeaderTimeout { get; set; }
        /// <summary>
        /// Mark server cookies with the 'Secure' attribute.
        /// Client browsers will not send a cookie marked as secure
        /// over an unencrypted connection.
        /// If Avi is terminating SSL from clients and passing it as
        /// HTTP to the server, the server may return cookies without
        /// the secure flag set.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "secure_cookie_enabled")]
        public bool? SecureCookieEnabled { get; set; }
        /// <summary>
        /// Maximum size in Kbytes of all the HTTP response headers.
        /// Allowed values are 1-256.
        /// Unit is KB.
        /// Allowed in Basic(Allowed values- 48) edition,
        /// Essentials(Allowed values- 48) edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 48.
        /// </summary>
        [JsonProperty(PropertyName = "max_response_headers_size")]
        public long? MaxResponseHeadersSize { get; set; }
        /// <summary>
        /// Provide a custom name for the X-Forwarded-For header sent
        /// to the servers.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as X-Forwarded-For.
        /// </summary>
        [JsonProperty(PropertyName = "xff_alternate_name")]
        public string? XffAlternateName { get; set; }
        /// <summary>
        /// Maximum requests per second per client IP.
        /// Allowed values are 10-1000.
        /// Special values are 0- 'unlimited'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "max_rps_cip")]
        public long? MaxRpsCip { get; set; }
        /// <summary>
        /// Maximum size for the client request body.
        /// This limits the size of the client data that can be
        /// uploaded/posted as part of a single HTTP Request.
        /// Default 0 => Unlimited.
        /// Unit is KB.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "client_max_body_size")]
        public long? ClientMaxBodySize { get; set; }
        /// <summary>
        /// Enable support for fire and forget feature.
        /// If enabled, request from client is forwarded to server even
        /// if client prematurely closes the connection.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enable_fire_and_forget")]
        public bool? EnableFireAndForget { get; set; }
        /// <summary>
        /// Maximum unknown client IPs per second.
        /// Allowed values are 10-1000.
        /// Special values are 0- 'unlimited'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "max_rps_unknown_cip")]
        public long? MaxRpsUnknownCip { get; set; }
        /// <summary>
        /// Allow use of dot (.) in HTTP header names, for instance
        /// Header.app.special  PickAppVersionX.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "allow_dots_in_header_name")]
        public bool? AllowDotsInHeaderName { get; set; }
        /// <summary>
        /// Select the PKI profile to be associated with the Virtual
        /// Service.
        /// This profile defines the Certificate Authority and
        /// Revocation List.
        /// It is a reference to an object of type PKIProfile.
        /// </summary>
        [JsonProperty(PropertyName = "pki_profile_path")]
        public string? PkiProfilePath { get; set; }
        /// <summary>
        /// Maximum bad requests per second per URI.
        /// Allowed values are 10-1000.
        /// Special values are 0- 'unlimited'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "max_bad_rps_uri")]
        public long? MaxBadRpsUri { get; set; }
        /// <summary>
        /// Use 'Keep-Alive' header timeout sent by application instead
        /// of sending the HTTP Keep-Alive Timeout.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "use_app_keepalive_timeout")]
        public bool? UseAppKeepaliveTimeout { get; set; }
    }
}
