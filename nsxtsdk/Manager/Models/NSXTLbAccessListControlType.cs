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
    /// LbAccessListControl is used to define how IP access list control can filter
        /// the connections from clients.
    /// </summary>
    [NSXTProperty(Description: @"LbAccessListControl is used to define how IP access list control can filterthe connections from clients.")]
    public class NSXTLbAccessListControlType 
    {
        /// <summary>
        /// ALLOW means connections matching grouping object IP list are allowed
        /// and requests not matching grouping object IP list are dropped.
        /// DROP means connections matching grouping object IP list are dropped
        /// and requests not matching grouping object IP list are allowed.
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbAccessListControlActionEnumType Action { get; set; }
        /// <summary>
        /// The identifier of grouping object which defines the IP addresses or
        /// ranges to match the client IP.
        /// </summary>
        [JsonProperty(PropertyName = "group_id", Required = Required.AllowNull)]
        public string GroupId { get; set; }
        /// <summary>
        /// The enabled flag indicates whether to enable access list control option.
        /// It is false by default.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
    }
}
