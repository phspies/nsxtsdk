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
    public class NSXTLbCookieTimeType 
    {
        /// <summary>
        /// Both session cookie and persistence cookie are supported,
        /// Use LbSessionCookieTime for session cookie time setting,
        /// Use LbPersistenceCookieTime for persistence cookie time setting
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbCookieTimeTypeEnumType Type { get; set; }
    }
}
