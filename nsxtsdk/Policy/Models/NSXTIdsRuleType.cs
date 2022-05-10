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
    public class NSXTIdsRuleType : NSXTBaseRuleType
    {
        /// <summary>
        /// The action to be applied.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIdsRuleActionEnumType? Action { get; set; }
        /// <summary>
        /// collections of IDS or Anti-Malware profiles. At Max 1 each Profile will be supported.
        /// </summary>
        [JsonProperty(PropertyName = "ids_profiles")]
        public IList<string> IdsProfiles { get; set; }
    }
}
