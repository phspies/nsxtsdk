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
    /// The summary of the failed DNS query. The query result represents a full
        /// query chain from client VM to dns forwarder, and upstream server if no
        /// forwarder cache was hit.
    /// </summary>
    [NSXTProperty(Description: @"The summary of the failed DNS query. The query result represents a fullquery chain from client VM to dns forwarder, and upstream server if noforwarder cache was hit.")]
    public class NSXTDnsFailedQueryType 
    {
        /// <summary>
        /// The time the query took before it got a failed answer, in ms.
        /// </summary>
        [JsonProperty(PropertyName = "time_spent")]
        public long? TimeSpent { get; set; }
        /// <summary>
        /// The record type be queried, e.g. A, CNAME, SOA, etc.
        /// </summary>
        [JsonProperty(PropertyName = "record_type")]
        public string? RecordType { get; set; }
        /// <summary>
        /// The client host ip address from which the query was issued.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        public string? ClientIp { get; set; }
        /// <summary>
        /// The upstream server ip address to which the query was forwarded. If the
        /// query could not be serviced from the DNS forwarder cache, this property
        /// will contain the IP address of the DNS server that serviced the request.
        /// If the request was serviced from the cache, this property will be absent.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_server_ip")]
        public string? UpstreamServerIp { get; set; }
        /// <summary>
        /// The detailed error message of the failed query, if any.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// The address be queried, can be a FQDN or an ip address.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string? Address { get; set; }
        /// <summary>
        /// Timestamp of the request, in YYYY-MM-DD HH:MM:SS.zzz format.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp", Required = Required.AllowNull)]
        public string Timestamp { get; set; }
        /// <summary>
        /// The type of the query failure, e.g. NXDOMAIN, etc.
        /// </summary>
        [JsonProperty(PropertyName = "error_type")]
        public string? ErrorType { get; set; }
        /// <summary>
        /// The source ip address that is used to forward a query to an upstream
        /// server.
        /// </summary>
        [JsonProperty(PropertyName = "source_ip")]
        public string? SourceIp { get; set; }
        /// <summary>
        /// The DNS forwarder ip address to which the query was first received.
        /// </summary>
        [JsonProperty(PropertyName = "forwarder_ip")]
        public string? ForwarderIp { get; set; }
    }
}
