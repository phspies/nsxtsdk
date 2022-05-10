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
    /// Describes status of configuration of an entity
    /// </summary>
    [NSXTProperty(Description: @"Describes status of configuration of an entity")]
    public class NSXTConfigurationStateType 
    {
        /// <summary>
        /// Gives details of state of desired configuration.
        /// Additional enums with more details on progress/success/error states
        /// are sent for edge node. The success states are NODE_READY and
        /// TRANSPORT_NODE_READY, pending states are {VM_DEPLOYMENT_QUEUED,
        /// VM_DEPLOYMENT_IN_PROGRESS, REGISTRATION_PENDING} and other values
        /// indicate failures.
        /// "in_sync" state indicates that the desired configuration has been
        /// received by the host to which it applies, but is not yet in effect.
        /// When the configuration is actually in effect, the state will
        /// change to "success".
        /// Please note, failed state is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTConfigurationStateStateEnumType? State { get; set; }
        /// <summary>
        /// Array of configuration state of various sub systems
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<NSXTConfigurationStateElementType> Details { get; set; }
        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty(PropertyName = "failure_code")]
        public long? FailureCode { get; set; }
        /// <summary>
        /// Error message in case of failure
        /// </summary>
        [JsonProperty(PropertyName = "failure_message")]
        public string? FailureMessage { get; set; }
    }
}
