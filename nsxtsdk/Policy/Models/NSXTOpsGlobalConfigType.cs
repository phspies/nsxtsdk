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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTOpsGlobalConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "in_band_network_telementry")]
        public NSXTDscpIndicatorType InBandNetworkTelementry { get; set; }
        /// <summary>
        /// The operation collector is defined to receive stats from hosts.
        /// The VRNI and WAVE_FRONT collector type can be defined to collect the metric data.
        /// The WAVE_FRONT collector type can only be used in VMC mode.
        /// </summary>
        [JsonProperty(PropertyName = "operation_collectors")]
        public IList<NSXTGlobalCollectorConfigType> OperationCollectors { get; set; }
    }
}
