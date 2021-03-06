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
    /// Advanced load balancer FullClientLogs object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer FullClientLogs object")]
    public class NSXTALBFullClientLogsType 
    {
        /// <summary>
        /// How long should the system capture all logs, measured in
        /// minutes.
        /// Set to 0 for infinite.
        /// Special values are 0 - 'infinite'.
        /// Unit is MIN.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 30.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public long? Duration { get; set; }
        /// <summary>
        /// This setting limits the number of non-significant logs
        /// generated per second for this VS on each SE.
        /// Default is 10 logs per second.
        /// Set it to zero (0) to deactivate throttling.
        /// Unit is PER_SECOND.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 10.
        /// </summary>
        [JsonProperty(PropertyName = "throttle")]
        public long? Throttle { get; set; }
        /// <summary>
        /// Capture all client logs including connections and requests.
        /// When deactivated, only errors will be logged.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Special default for Basic edition is false, Essentials
        /// edition is false, Enterprise is False.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
    }
}
