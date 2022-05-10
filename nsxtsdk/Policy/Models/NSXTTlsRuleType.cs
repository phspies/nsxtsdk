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
    public class NSXTTlsRuleType : NSXTBaseRuleType
    {
        /// <summary>
        /// TLS profile path.
        /// </summary>
        [JsonProperty(PropertyName = "tls_profile", Required = Required.AllowNull)]
        public string TlsProfile { get; set; }
    }
}
