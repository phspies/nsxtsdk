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
    /// LBAccessListControl is used to define how IP access list control can filter
        /// the connections from clients.
    /// </summary>
    [NSXTProperty(Description: @"LBAccessListControl is used to define how IP access list control can filterthe connections from clients.")]
    public class NSXTLBAccessListControlType 
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
        public NSXTLbaccessListControlActionEnumType Action { get; set; }
        /// <summary>
        /// The path of grouping object which defines the IP addresses or
        /// ranges to match the client IP.
        /// </summary>
        [JsonProperty(PropertyName = "group_path", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The path of grouping object which defines the IP addresses orranges to match the client IP.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string GroupPath { get; set; }
        /// <summary>
        /// The enabled flag indicates whether to enable access list control option.
        /// It is false by default.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [NSXTProperty(IsRequired: false, Description: @"The enabled flag indicates whether to enable access list control option.It is false by default.")]
        public bool? Enabled { get; set; }
    }
}