// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLBCookiePersistenceProfileType : NSXTLBPersistenceProfileType
    {
        /// <summary>
        /// If garble is set to true, cookie value (server IP and port) would be
        /// encrypted.
        /// If garble is set to false, cookie value would be plain text.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_garble")]
        [NSXTProperty(IsRequired: false, Description: @"If garble is set to true, cookie value (server IP and port) would beencrypted.If garble is set to false, cookie value would be plain text.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? CookieGarble { get; set; }
        /// <summary>
        /// If cookie secure flag is true, it prevents the browser from sending a
        /// cookie over http. The cookie is sent only over https. Only available
        /// for insert mode.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_secure")]
        [NSXTProperty(IsRequired: false, Description: @"If cookie secure flag is true, it prevents the browser from sending acookie over http. The cookie is sent only over https. Only availablefor insert mode.")]
        public bool? CookieSecure { get; set; }
        /// <summary>
        /// If fallback is true, once the cookie points to a server that is down
        /// (i.e. admin state DISABLED or healthcheck state is DOWN), then a new
        /// server is selected by default to handle that request.
        /// If fallback is false, it will cause the request to be rejected if
        /// cookie points to a server.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_fallback")]
        [NSXTProperty(IsRequired: false, Description: @"If fallback is true, once the cookie points to a server that is down(i.e. admin state DISABLED or healthcheck state is DOWN), then a newserver is selected by default to handle that request.If fallback is false, it will cause the request to be rejected ifcookie points to a server.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? CookieFallback { get; set; }
        /// <summary>
        /// Cookie persistence mode.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_mode")]
        [NSXTProperty(IsRequired: false, Description: @"Cookie persistence mode.")]
        [NSXTDefaultProperty(Default: "INSERT")]
        public NSXTLbcookiePersistenceProfileCookieModeEnumType? CookieMode { get; set; }
        /// <summary>
        /// HTTP cookie domain could be configured, only available for insert mode.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_domain")]
        [NSXTProperty(IsRequired: false, Description: @"HTTP cookie domain could be configured, only available for insert mode.")]
        public string? CookieDomain { get; set; }
        /// <summary>
        /// If cookie httponly flag is true, it prevents a script running in the
        /// browser from accessing the cookie. Only available for insert mode.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_httponly")]
        [NSXTProperty(IsRequired: false, Description: @"If cookie httponly flag is true, it prevents a script running in thebrowser from accessing the cookie. Only available for insert mode.")]
        public bool? CookieHttponly { get; set; }
        /// <summary>
        /// Cookie name.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_name")]
        [NSXTProperty(IsRequired: false, Description: @"Cookie name.")]
        [NSXTDefaultProperty(Default: "NSXLB")]
        public string? CookieName { get; set; }
        /// <summary>
        /// Both session cookie and persistence cookie are supported, if not
        /// specified, it's a session cookie. It expires when the browser is
        /// closed.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_time")]
        [NSXTProperty(IsRequired: false, Description: @"Both session cookie and persistence cookie are supported, if notspecified, it&apos;s a session cookie. It expires when the browser isclosed.")]
        public NSXTLBCookieTimeType CookieTime { get; set; }
        /// <summary>
        /// HTTP cookie path could be set, only available for insert mode.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_path")]
        [NSXTProperty(IsRequired: false, Description: @"HTTP cookie path could be set, only available for insert mode.")]
        public string? CookiePath { get; set; }
    }
}
