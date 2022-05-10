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
    /// LACP group
    /// </summary>
    [NSXTProperty(Description: @"LACP group")]
    public class NSXTLagType 
    {
        /// <summary>
        /// uplink names
        /// </summary>
        [JsonProperty(PropertyName = "uplinks")]
        public IList<NSXTUplinkType> Uplinks { get; set; }
        /// <summary>
        /// Lag name
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// number of uplinks
        /// </summary>
        [JsonProperty(PropertyName = "number_of_uplinks", Required = Required.AllowNull)]
        public int NumberOfUplinks { get; set; }
        /// <summary>
        /// LACP timeout type
        /// </summary>
        [JsonProperty(PropertyName = "timeout_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLagTimeoutTypeEnumType? TimeoutType { get; set; }
        /// <summary>
        /// LACP load balance Algorithm
        /// </summary>
        [JsonProperty(PropertyName = "load_balance_algorithm", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLagLoadBalanceAlgorithmEnumType LoadBalanceAlgorithm { get; set; }
        /// <summary>
        /// unique id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// LACP group mode
        /// </summary>
        [JsonProperty(PropertyName = "mode", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLagModeEnumType Mode { get; set; }
    }
}
