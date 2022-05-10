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
    /// Properties that affect the configuration of the NSX API service.
    /// </summary>
    [NSXTProperty(Description: @"Properties that affect the configuration of the NSX API service.")]
    public class NSXTApiServiceConfigType 
    {
        /// <summary>
        /// The maximum number of concurrent API requests that will be serviced. If the number of API requests being processed
        /// exceeds this limit, new API requests will be refused and a 503 Service Unavailable response will be returned to the
        /// client.  To disable API concurrency limiting, set this value to 0.
        /// </summary>
        [JsonProperty(PropertyName = "global_api_concurrency_limit")]
        public long? GlobalApiConcurrencyLimit { get; set; }
        /// <summary>
        /// The list of IP addresses which are not subjected to a lockout on failed login attempts.
        /// </summary>
        [JsonProperty(PropertyName = "lockout_immune_addresses")]
        public IList<string> LockoutImmuneAddresses { get; set; }
        /// <summary>
        /// Identifies whether basic authentication is enabled or disabled in API calls.
        /// </summary>
        [JsonProperty(PropertyName = "basic_authentication_enabled")]
        public bool? BasicAuthenticationEnabled { get; set; }
        /// <summary>
        /// Host name or IP address to use for redirect location headers, or empty string to derive from current request. To
        /// disable, set redirect_host to the empty string ("").
        /// </summary>
        [JsonProperty(PropertyName = "redirect_host")]
        public string? RedirectHost { get; set; }
        /// <summary>
        /// The TLS cipher suites that the API service will negotiate.
        /// </summary>
        [JsonProperty(PropertyName = "cipher_suites")]
        public IList<NSXTCipherSuiteType> CipherSuites { get; set; }
        /// <summary>
        /// Identifies whether cookie-based authentication is enabled or disabled in API calls. When cookie-based authentication is
        /// disabled, new sessions cannot be created via /api/session/create.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_based_authentication_enabled")]
        public bool? CookieBasedAuthenticationEnabled { get; set; }
        /// <summary>
        /// NSX session inactivity timeout
        /// </summary>
        [JsonProperty(PropertyName = "session_timeout")]
        public long? SessionTimeout { get; set; }
        /// <summary>
        /// The maximum number of API requests that will be serviced per second for a given authenticated client.  If more API
        /// requests are received than can be serviced, a 429 Too Many Requests HTTP response will be returned. To disable API rate
        /// limiting, set this value to 0.
        /// </summary>
        [JsonProperty(PropertyName = "client_api_rate_limit")]
        public long? ClientApiRateLimit { get; set; }
        /// <summary>
        /// The maximum number of concurrent API requests that will be serviced for a given authenticated client.  If the number of
        /// API requests being processed exceeds this limit, new API requests will be refused and a 503 Service Unavailable response
        /// will be returned to the client. To disable API concurrency limiting, set this value to 0.
        /// </summary>
        [JsonProperty(PropertyName = "client_api_concurrency_limit")]
        public long? ClientApiConcurrencyLimit { get; set; }
        /// <summary>
        /// The TLS protocol versions that the API service will negotiate.
        /// </summary>
        [JsonProperty(PropertyName = "protocol_versions")]
        public IList<NSXTProtocolVersionType> ProtocolVersions { get; set; }
        /// <summary>
        /// NSX connection timeout, in seconds. To disable timeout, set to 0.
        /// </summary>
        [JsonProperty(PropertyName = "connection_timeout")]
        public long? ConnectionTimeout { get; set; }
    }
}
