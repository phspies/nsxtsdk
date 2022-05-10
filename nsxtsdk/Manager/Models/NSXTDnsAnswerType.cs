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
    /// The response for DNS nslookup.
    /// </summary>
    [NSXTProperty(Description: @"The response for DNS nslookup.")]
    public class NSXTDnsAnswerType 
    {
        /// <summary>
        /// Dns server ip address and port, format is "ip address#port".
        /// </summary>
        [JsonProperty(PropertyName = "dns_server", Required = Required.AllowNull)]
        public string DnsServer { get; set; }
        /// <summary>
        /// It can be NXDOMAIN or error message which is not consisted of
        /// authoritative_answer or non_authoritative_answer.
        /// </summary>
        [JsonProperty(PropertyName = "raw_answer")]
        public string? RawAnswer { get; set; }
        /// <summary>
        /// Non-authotitative answers of the query.
        /// This is a deprecated property, please use 'answers' instead.
        /// </summary>
        [JsonProperty(PropertyName = "non_authoritative_answers")]
        public IList<NSXTDnsQueryAnswerType> NonAuthoritativeAnswers { get; set; }
        /// <summary>
        /// The source ip used in this lookup.
        /// </summary>
        [JsonProperty(PropertyName = "source_ip", Required = Required.AllowNull)]
        public string SourceIp { get; set; }
        /// <summary>
        /// ID of the edge node that performed the query.
        /// </summary>
        [JsonProperty(PropertyName = "edge_node_id", Required = Required.AllowNull)]
        public string EdgeNodeId { get; set; }
        /// <summary>
        /// Authotitative answers of the query.
        /// This is a deprecated property, please use 'answers' instead.
        /// </summary>
        [JsonProperty(PropertyName = "authoritative_answers")]
        public IList<NSXTDnsQueryAnswerType> AuthoritativeAnswers { get; set; }
        /// <summary>
        /// The answers of the query.
        /// </summary>
        [JsonProperty(PropertyName = "answers")]
        public IList<NSXTDnsQueryAnswerType> Answers { get; set; }
    }
}
