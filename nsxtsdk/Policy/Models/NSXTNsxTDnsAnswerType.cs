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
    public class NSXTNsxTDnsAnswerType : NSXTPolicyDnsAnswerPerEnforcementPointType
    {
        /// <summary>
        /// Authoritative answers
        /// </summary>
        [JsonProperty(PropertyName = "authoritative_answers")]
        public IList<NSXTNsxTDnsQueryAnswerType> AuthoritativeAnswers { get; set; }
        /// <summary>
        /// ID of the edge node that performed the query.
        /// </summary>
        [JsonProperty(PropertyName = "edge_node_id", Required = Required.AllowNull)]
        public string EdgeNodeId { get; set; }
        /// <summary>
        /// Dns server ip address and port, format is "ip address#port".
        /// </summary>
        [JsonProperty(PropertyName = "dns_server", Required = Required.AllowNull)]
        public string DnsServer { get; set; }
        /// <summary>
        /// Non authoritative answers
        /// </summary>
        [JsonProperty(PropertyName = "non_authoritative_answers")]
        public IList<NSXTNsxTDnsQueryAnswerType> NonAuthoritativeAnswers { get; set; }
        /// <summary>
        /// It can be NXDOMAIN or error message which is not consisted of
        /// authoritative_answer or non_authoritative_answer.
        /// </summary>
        [JsonProperty(PropertyName = "raw_answer")]
        public string? RawAnswer { get; set; }
    }
}
