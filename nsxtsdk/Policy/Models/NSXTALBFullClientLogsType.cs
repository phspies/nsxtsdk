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
        [NSXTProperty(IsRequired: false, Description: @"How long should the system capture all logs, measured inminutes.Set to 0 for infinite.Special values are 0 - &apos;infinite&apos;.Unit is MIN.Default value when not specified in API or module isinterpreted by ALB Controller as 30.")]
        [NSXTDefaultProperty(Default: "")]
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
        [NSXTProperty(IsRequired: false, Description: @"This setting limits the number of non-significant logsgenerated per second for this VS on each SE.Default is 10 logs per second.Set it to zero (0) to deactivate throttling.Unit is PER_SECOND.Default value when not specified in API or module isinterpreted by ALB Controller as 10.")]
        [NSXTDefaultProperty(Default: "")]
        public long? Throttle { get; set; }
        /// <summary>
        /// Capture all client logs including connections and requests.
        /// When deactivated, only errors will be logged.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Capture all client logs including connections and requests.When deactivated, only errors will be logged.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Enabled { get; set; }
    }
}
