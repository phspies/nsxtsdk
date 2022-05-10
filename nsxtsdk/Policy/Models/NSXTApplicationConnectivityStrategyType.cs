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
    /// Allows more granular policies for application workloads
    /// </summary>
    [NSXTProperty(Description: @"Allows more granular policies for application workloads")]
    public class NSXTApplicationConnectivityStrategyType 
    {
        /// <summary>
        /// Flag to enable packet logging. Default is disabled.
        /// </summary>
        [JsonProperty(PropertyName = "logging_enabled")]
        public bool? LoggingEnabled { get; set; }
        /// <summary>
        /// Based on the value of the app connectivity strategy, a default rule is
        /// created for the security policy. The rule id is internally assigned
        /// by the system for this default rule.
        /// </summary>
        [JsonProperty(PropertyName = "default_application_rule_id")]
        public long? DefaultApplicationRuleId { get; set; }
        /// <summary>
        /// App connectivity strategies
        /// </summary>
        [JsonProperty(PropertyName = "application_connectivity_strategy", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTApplicationConnectivityStrategyApplicationConnectivityStrategyEnumType ApplicationConnectivityStrategy { get; set; }
    }
}
