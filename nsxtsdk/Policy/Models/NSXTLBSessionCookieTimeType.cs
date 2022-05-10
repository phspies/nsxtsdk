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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLBSessionCookieTimeType : NSXTLBCookieTimeType
    {
        /// <summary>
        /// Instead of using HTTP Cookie max-age and relying on client to expire
        /// the cookie, max idle time and/or max lifetime of the cookie can be used.
        /// Max idle time, if configured, specifies the maximum interval the cookie
        /// is valid for from the last time it was seen in a request.
        /// It is available for insert mode.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_max_idle")]
        public long? CookieMaxIdle { get; set; }
        /// <summary>
        /// Max life time, if configured, specifies the maximum interval the cookie
        /// is valid for from the first time the cookie was seen in a request.
        /// It is available for insert mode.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_max_life")]
        public long? CookieMaxLife { get; set; }
    }
}
