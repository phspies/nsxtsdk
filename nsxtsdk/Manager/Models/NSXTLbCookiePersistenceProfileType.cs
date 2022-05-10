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
    public class NSXTLbCookiePersistenceProfileType : NSXTLbPersistenceProfileType
    {
        /// <summary>
        /// If garble is set to true, cookie value (server IP and port) would be
        /// encrypted.
        /// If garble is set to false, cookie value would be plain text.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_garble")]
        public bool? CookieGarble { get; set; }
        /// <summary>
        /// If cookie secure flag is true, it prevents the browser from sending a
        /// cookie over http. The cookie is sent only over https. Only
        /// available for insert mode.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_secure")]
        public bool? CookieSecure { get; set; }
        /// <summary>
        /// If fallback is true, once the cookie points to a server that is down
        /// (i.e. admin state DISABLED or healthcheck state is DOWN), then a new
        /// server is selected by default to handle that request.
        /// If fallback is false, it will cause the request to be rejected if
        /// cookie points to a server
        /// </summary>
        [JsonProperty(PropertyName = "cookie_fallback")]
        public bool? CookieFallback { get; set; }
        /// <summary>
        /// cookie persistence mode
        /// </summary>
        [JsonProperty(PropertyName = "cookie_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbCookiePersistenceProfileCookieModeEnumType? CookieMode { get; set; }
        /// <summary>
        /// HTTP cookie domain could be configured, only available for insert mode.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_domain")]
        public string? CookieDomain { get; set; }
        /// <summary>
        /// If cookie httponly flag is true, it prevents a script running in the
        /// browser from accessing the cookie. Only available for insert mode.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_httponly")]
        public bool? CookieHttponly { get; set; }
        /// <summary>
        /// cookie name
        /// </summary>
        [JsonProperty(PropertyName = "cookie_name", Required = Required.AllowNull)]
        public string CookieName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "cookie_time")]
        public NSXTLbCookieTimeType CookieTime { get; set; }
        /// <summary>
        /// HTTP cookie path could be set, only available for insert mode.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_path")]
        public string? CookiePath { get; set; }
    }
}
