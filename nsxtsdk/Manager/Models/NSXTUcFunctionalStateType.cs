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
    /// Upgrade coordinator Uc functional State.
    /// </summary>
    [NSXTProperty(Description: @"Upgrade coordinator Uc functional State.")]
    public class NSXTUcFunctionalStateType 
    {
        /// <summary>
        /// function state of the upgrade coordinator
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUcFunctionalStateStateEnumType? State { get; set; }
        /// <summary>
        /// error message that explains why UC is on standby mode.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
    }
}
