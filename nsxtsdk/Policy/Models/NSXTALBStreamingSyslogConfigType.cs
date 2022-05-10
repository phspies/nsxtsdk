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
    /// Advanced load balancer StreamingSyslogConfig object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer StreamingSyslogConfig object")]
    public class NSXTALBStreamingSyslogConfigType 
    {
        /// <summary>
        /// Severity code, as defined in RFC5424, for non-significant
        /// logs.
        /// This must be between 0 and 7 inclusive.
        /// Allowed values are 0-7.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 6.
        /// </summary>
        [JsonProperty(PropertyName = "non_significant_log_severity")]
        public long? NonSignificantLogSeverity { get; set; }
        /// <summary>
        /// Severity code, as defined in RFC5424, for filtered logs.
        /// This must be between 0 and 7 inclusive.
        /// Allowed values are 0-7.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 5.
        /// </summary>
        [JsonProperty(PropertyName = "filtered_log_severity")]
        public long? FilteredLogSeverity { get; set; }
        /// <summary>
        /// String to use as the hostname in the syslog messages.
        /// This string can contain only printable ASCII characters
        /// (hex 21 to hex 7E; no space allowed).
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as AviVantage.
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string? Hostname { get; set; }
        /// <summary>
        /// Severity code, as defined in RFC5424, for significant logs.
        /// This must be between 0 and 7 inclusive.
        /// Allowed values are 0-7.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 4.
        /// </summary>
        [JsonProperty(PropertyName = "significant_log_severity")]
        public long? SignificantLogSeverity { get; set; }
        /// <summary>
        /// Facility value, as defined in RFC5424, must be between 0
        /// and 23 inclusive.
        /// Allowed values are 0-23.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 16.
        /// </summary>
        [JsonProperty(PropertyName = "facility")]
        public long? Facility { get; set; }
    }
}
