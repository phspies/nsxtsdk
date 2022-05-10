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
    /// Advanced load balancer WafExcludeListEntry object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer WafExcludeListEntry object")]
    public class NSXTALBWafExcludeListEntryType 
    {
        /// <summary>
        /// URI Path to exclude for WAF rules.
        /// </summary>
        [JsonProperty(PropertyName = "uri_path")]
        public string? UriPath { get; set; }
        /// <summary>
        /// Free-text comment about this exclusion.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "uri_match_criteria")]
        public NSXTALBWafExclusionTypeType UriMatchCriteria { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "match_element_criteria")]
        public NSXTALBWafExclusionTypeType MatchElementCriteria { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_subnet")]
        public NSXTALBIpAddrPrefixType ClientSubnet { get; set; }
        /// <summary>
        /// The match_element can be 'ARGS xxx', 'ARGS_GET xxx',
        /// 'ARGS_POST xxx', 'ARGS_NAMES xxx', 'FILES xxx',
        /// 'QUERY_STRING', 'REQUEST_BASENAME', 'REQUEST_BODY',
        /// 'REQUEST_URI', 'REQUEST_URI_RAW', 'REQUEST_COOKIES xxx',
        /// 'REQUEST_HEADERS xxx' or 'RESPONSE_HEADERS xxx'.
        /// These match_elements in the HTTP Transaction (if present)
        /// will be excluded when executing WAF Rules.
        /// </summary>
        [JsonProperty(PropertyName = "match_element")]
        public string? MatchElement { get; set; }
    }
}
