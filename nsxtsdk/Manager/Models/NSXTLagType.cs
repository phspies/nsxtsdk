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
    /// LACP group
    /// </summary>
    [NSXTProperty(Description: @"LACP group")]
    public class NSXTLagType 
    {
        /// <summary>
        /// uplink names
        /// </summary>
        [JsonProperty(PropertyName = "uplinks")]
        [NSXTProperty(IsRequired: false, Description: @"uplink names")]
        public IList<NSXTUplinkType> Uplinks { get; set; }
        /// <summary>
        /// Lag name
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Lag name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// number of uplinks
        /// </summary>
        [JsonProperty(PropertyName = "number_of_uplinks", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"number of uplinks")]
        //[System.ComponentModel.DataAnnotations.MinLength(2)]
        //[System.ComponentModel.DataAnnotations.MaxLength(32)]
        [System.ComponentModel.DataAnnotations.Required]
        public int NumberOfUplinks { get; set; }
        /// <summary>
        /// LACP timeout type
        /// </summary>
        [JsonProperty(PropertyName = "timeout_type")]
        [NSXTProperty(IsRequired: false, Description: @"LACP timeout type")]
        [NSXTDefaultProperty(Default: "SLOW")]
        public NSXTLagTimeoutTypeEnumType? TimeoutType { get; set; }
        /// <summary>
        /// LACP load balance Algorithm
        /// </summary>
        [JsonProperty(PropertyName = "load_balance_algorithm", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"LACP load balance Algorithm")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTLagLoadBalanceAlgorithmEnumType LoadBalanceAlgorithm { get; set; }
        /// <summary>
        /// unique id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        [NSXTProperty(IsRequired: false, Description: @"unique id")]
        public string? Id { get; set; }
        /// <summary>
        /// LACP group mode
        /// </summary>
        [JsonProperty(PropertyName = "mode", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"LACP group mode")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTLagModeEnumType Mode { get; set; }
    }
}
