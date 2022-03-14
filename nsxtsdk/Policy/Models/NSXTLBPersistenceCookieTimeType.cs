// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
