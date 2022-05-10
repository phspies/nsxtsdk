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
    public class NSXTTlsPolicyType : NSXTPolicyType
    {
        /// <summary>
        /// Rules that are a part of this TLSPolicy
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTTlsRuleType> Rules { get; set; }
    }
}
