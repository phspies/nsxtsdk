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
    /// Monitoring information is gathered from multiple sub-systems/components, using
        /// REST or RPC calls internally. It is quite possible for a component or sub-system
        /// fail, in which case it is captured as an error and reported.
    /// </summary>
    [NSXTProperty(Description: @"Monitoring information is gathered from multiple sub-systems/components, usingREST or RPC calls internally. It is quite possible for a component or sub-systemfail, in which case it is captured as an error and reported.")]
    public class NSXTMonitoringErrorType 
    {
        /// <summary>
        /// Parameters for construcing error details
        /// </summary>
        [JsonProperty(PropertyName = "params")]
        public IList<object> Params { get; set; }
        /// <summary>
        /// Error mesage
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// NSX error code if available
        /// </summary>
        [JsonProperty(PropertyName = "error_code")]
        public long? ErrorCode { get; set; }
    }
}
