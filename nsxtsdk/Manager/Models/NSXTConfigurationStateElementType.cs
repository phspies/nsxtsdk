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
    /// Describes status of configuration of an entity
    /// </summary>
    [NSXTProperty(Description: @"Describes status of configuration of an entity")]
    public class NSXTConfigurationStateElementType 
    {
        /// <summary>
        /// URI of backing resource on sub system
        /// </summary>
        [JsonProperty(PropertyName = "sub_system_address")]
        [NSXTProperty(IsRequired: false, Description: @"URI of backing resource on sub system")]
        public string? SubSystemAddress { get; set; }
        /// <summary>
        /// State of configuration on this sub system
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [NSXTProperty(IsRequired: false, Description: @"State of configuration on this sub system")]
        public NSXTConfigurationStateElementStateEnumType? State { get; set; }
        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty(PropertyName = "failure_code")]
        [NSXTProperty(IsRequired: false, Description: @"Error code")]
        public long? FailureCode { get; set; }
        /// <summary>
        /// Name of backing resource on sub system
        /// </summary>
        [JsonProperty(PropertyName = "sub_system_name")]
        [NSXTProperty(IsRequired: false, Description: @"Name of backing resource on sub system")]
        public string? SubSystemName { get; set; }
        /// <summary>
        /// Error message in case of failure
        /// </summary>
        [JsonProperty(PropertyName = "failure_message")]
        [NSXTProperty(IsRequired: false, Description: @"Error message in case of failure")]
        public string? FailureMessage { get; set; }
        /// <summary>
        /// Type of backing resource on sub system
        /// </summary>
        [JsonProperty(PropertyName = "sub_system_type")]
        [NSXTProperty(IsRequired: false, Description: @"Type of backing resource on sub system")]
        public string? SubSystemType { get; set; }
        /// <summary>
        /// Identifier of backing resource on sub system
        /// </summary>
        [JsonProperty(PropertyName = "sub_system_id")]
        [NSXTProperty(IsRequired: false, Description: @"Identifier of backing resource on sub system")]
        public string? SubSystemId { get; set; }
    }
}
