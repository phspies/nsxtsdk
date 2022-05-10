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
    /// Advanced load balancer DnsQueryNameMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsQueryNameMatch object")]
    public class NSXTALBDnsQueryNameMatchType 
    {
        /// <summary>
        /// path of the string group(s) for matching against DNS query
        /// domain name in the question section.
        /// It is a reference to an object of type StringGroup.
        /// </summary>
        [JsonProperty(PropertyName = "string_group_paths")]
        public IList<string> StringGroupPaths { get; set; }
        /// <summary>
        /// Domain name to match against that specified in the question
        /// section of the DNS query.
        /// </summary>
        [JsonProperty(PropertyName = "query_domain_names")]
        public IList<string> QueryDomainNames { get; set; }
        /// <summary>
        /// Criterion to use for string matching the DNS query domain
        /// name in the question section.
        /// Enum options - BEGINS_WITH, DOES_NOT_BEGIN_WITH, CONTAINS,
        /// DOES_NOT_CONTAIN, ENDS_WITH, DOES_NOT_END_WITH, EQUALS,
        /// DOES_NOT_EQUAL, REGEX_MATCH, REGEX_DOES_NOT_MATCH.
        /// Allowed in Basic(Allowed values-
        /// BEGINS_WITH,DOES_NOT_BEGIN_WITH,CONTAINS,DOES_NOT_CONTAIN,ENDS_WITH,DOES_NOT_END_WITH,EQUALS,DOES_NOT_EQUAL)
        /// edition, Essentials(Allowed values-
        /// BEGINS_WITH,DOES_NOT_BEGIN_WITH,CONTAINS,DOES_NOT_CONTAIN,ENDS_WITH,DOES_NOT_END_WITH,EQUALS,DOES_NOT_EQUAL)
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbdnsQueryNameMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
