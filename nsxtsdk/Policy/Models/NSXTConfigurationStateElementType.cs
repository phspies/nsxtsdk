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
    /// Describes status of configuration of an entity
    /// </summary>
    [NSXTProperty(Description: @"Describes status of configuration of an entity")]
    public class NSXTConfigurationStateElementType 
    {
        /// <summary>
        /// URI of backing resource on sub system
        /// </summary>
        [JsonProperty(PropertyName = "sub_system_address")]
        public string? SubSystemAddress { get; set; }
        /// <summary>
        /// State of configuration on this sub system
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTConfigurationStateElementStateEnumType? State { get; set; }
        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty(PropertyName = "failure_code")]
        public long? FailureCode { get; set; }
        /// <summary>
        /// Name of backing resource on sub system
        /// </summary>
        [JsonProperty(PropertyName = "sub_system_name")]
        public string? SubSystemName { get; set; }
        /// <summary>
        /// Error message in case of failure
        /// </summary>
        [JsonProperty(PropertyName = "failure_message")]
        public string? FailureMessage { get; set; }
        /// <summary>
        /// Type of backing resource on sub system
        /// </summary>
        [JsonProperty(PropertyName = "sub_system_type")]
        public string? SubSystemType { get; set; }
        /// <summary>
        /// Identifier of backing resource on sub system
        /// </summary>
        [JsonProperty(PropertyName = "sub_system_id")]
        public string? SubSystemId { get; set; }
    }
}
