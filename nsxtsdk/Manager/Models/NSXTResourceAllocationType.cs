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
    /// Specify limit, shares and reservation for all kinds of traffic.
        /// Values for limit and reservation are expressed in percentage. And for shares,
        /// the value is expressed as a number between 1-100.
        /// The overall reservation among all traffic types should not exceed 75%.
        /// Otherwise, the API request will be rejected.
    /// </summary>
    [NSXTProperty(Description: @"Specify limit, shares and reservation for all kinds of traffic.Values for limit and reservation are expressed in percentage. And for shares,the value is expressed as a number between 1-100.The overall reservation among all traffic types should not exceed 75%.Otherwise, the API request will be rejected.")]
    public class NSXTResourceAllocationType 
    {
        public NSXTResourceAllocationType()
        {
            Reservation = test
            Limit = test
            Shares = test
        }
        /// <summary>
        /// Minimum guaranteed bandwidth percentage
        /// </summary>
        [JsonProperty(PropertyName = "reservation", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Minimum guaranteed bandwidth percentage")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(75)]
        [System.ComponentModel.DataAnnotations.Required]
        public double Reservation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "traffic_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTHostInfraTrafficTypeType TrafficType { get; set; }
        /// <summary>
        /// The limit property specifies the maximum bandwidth allocation for a given
        /// traffic type and is expressed in percentage. The default value for this
        /// field is set to -1 which means the traffic is unbounded for the traffic
        /// type. All other negative values for this property is not supported
        /// and will be rejected by the API.
        /// </summary>
        [JsonProperty(PropertyName = "limit", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The limit property specifies the maximum bandwidth allocation for a giventraffic type and is expressed in percentage. The default value for thisfield is set to -1 which means the traffic is unbounded for the traffictype. All other negative values for this property is not supportedand will be rejected by the API.")]
        //[System.ComponentModel.DataAnnotations.MinLength(-1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(100)]
        [System.ComponentModel.DataAnnotations.Required]
        public double Limit { get; set; }
        /// <summary>
        /// Shares
        /// </summary>
        [JsonProperty(PropertyName = "shares", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Shares")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(100)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Shares { get; set; }
    }
}
