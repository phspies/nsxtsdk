// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: false, Description: @"URI Path to exclude for WAF rules.")]
        public string? UriPath { get; set; }
        /// <summary>
        /// Free-text comment about this exclusion.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        [NSXTProperty(IsRequired: false, Description: @"Free-text comment about this exclusion.")]
        public string? Description { get; set; }
        /// <summary>
        /// Criteria for URI matching.
        /// </summary>
        [JsonProperty(PropertyName = "uri_match_criteria")]
        [NSXTProperty(IsRequired: false, Description: @"Criteria for URI matching.")]
        public NSXTALBWafExclusionTypeType UriMatchCriteria { get; set; }
        /// <summary>
        /// Criteria for match_element matching.
        /// </summary>
        [JsonProperty(PropertyName = "match_element_criteria")]
        [NSXTProperty(IsRequired: false, Description: @"Criteria for match_element matching.")]
        public NSXTALBWafExclusionTypeType MatchElementCriteria { get; set; }
        /// <summary>
        /// Client IP Subnet to exclude for WAF rules.
        /// </summary>
        [JsonProperty(PropertyName = "client_subnet")]
        [NSXTProperty(IsRequired: false, Description: @"Client IP Subnet to exclude for WAF rules.")]
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
        [NSXTProperty(IsRequired: false, Description: @"The match_element can be &apos;ARGS xxx&apos;, &apos;ARGS_GET xxx&apos;,&apos;ARGS_POST xxx&apos;, &apos;ARGS_NAMES xxx&apos;, &apos;FILES xxx&apos;,&apos;QUERY_STRING&apos;, &apos;REQUEST_BASENAME&apos;, &apos;REQUEST_BODY&apos;,&apos;REQUEST_URI&apos;, &apos;REQUEST_URI_RAW&apos;, &apos;REQUEST_COOKIES xxx&apos;,&apos;REQUEST_HEADERS xxx&apos; or &apos;RESPONSE_HEADERS xxx&apos;.These match_elements in the HTTP Transaction (if present)will be excluded when executing WAF Rules.")]
        public string? MatchElement { get; set; }
    }
}
