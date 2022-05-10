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
    /// Cookie time.
    /// </summary>
    [NSXTProperty(Description: @"Cookie time.")]
    public class NSXTLBCookieTimeType 
    {
        /// <summary>
        /// Both session cookie and persistence cookie are supported,
        /// Use LbSessionCookieTime for session cookie time setting,
        /// Use LbPersistenceCookieTime for persistence cookie time setting
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbcookieTimeTypeEnumType Type { get; set; }
    }
}
