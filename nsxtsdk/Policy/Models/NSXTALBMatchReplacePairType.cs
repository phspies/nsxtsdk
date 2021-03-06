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
    /// Advanced load balancer MatchReplacePair object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer MatchReplacePair object")]
    public class NSXTALBMatchReplacePairType 
    {
        /// <summary>
        /// String to be matched.
        /// </summary>
        [JsonProperty(PropertyName = "match_string", Required = Required.AllowNull)]
        public string MatchString { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "replacement_string")]
        public NSXTALBReplaceStringVarType ReplacementString { get; set; }
    }
}
