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
    public class NSXTLBPersistenceCookieTimeType : NSXTLBCookieTimeType
    {
        /// <summary>
        /// HTTP cookie max-age to expire cookie, only available for insert mode.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_max_idle", Required = Required.AllowNull)]
        public long CookieMaxIdle { get; set; }
    }
}
