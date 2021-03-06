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
    /// Advanced load balancer DosThresholdProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DosThresholdProfile object")]
    public class NSXTALBDosThresholdProfileType 
    {
        /// <summary>
        /// Timer value in seconds to collect DoS attack metrics based
        /// on threshold on the Service Engine for this Virtual Service.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 5.
        /// </summary>
        [JsonProperty(PropertyName = "thresh_period", Required = Required.AllowNull)]
        public long ThreshPeriod { get; set; }
        /// <summary>
        /// Attack type, min and max values for DoS attack detection.
        /// </summary>
        [JsonProperty(PropertyName = "thresh_info")]
        public IList<NSXTALBDosThresholdType> ThreshInfo { get; set; }
    }
}
