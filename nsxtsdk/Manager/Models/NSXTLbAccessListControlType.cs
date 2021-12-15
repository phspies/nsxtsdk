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
        [NSXTProperty(IsRequired: true, Description: @"ALLOW means connections matching grouping object IP list are allowedand requests not matching grouping object IP list are dropped.DROP means connections matching grouping object IP list are droppedand requests not matching grouping object IP list are allowed.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTLbAccessListControlActionEnumType Action { get; set; }
        /// <summary>
        /// The identifier of grouping object which defines the IP addresses or
        /// ranges to match the client IP.
        /// </summary>
        [JsonProperty(PropertyName = "group_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The identifier of grouping object which defines the IP addresses orranges to match the client IP.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string GroupId { get; set; }
        /// <summary>
        /// The enabled flag indicates whether to enable access list control option.
        /// It is false by default.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [NSXTProperty(IsRequired: false, Description: @"The enabled flag indicates whether to enable access list control option.It is false by default.")]
        public bool? Enabled { get; set; }
    }
}