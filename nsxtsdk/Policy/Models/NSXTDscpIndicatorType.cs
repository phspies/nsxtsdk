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
    /// The DscpIndicator is the base class for global In-band network telemetry
        /// configurations for different types in a NSX domain.
    /// </summary>
    [NSXTProperty(Description: @"The DscpIndicator is the base class for global In-band network telemetryconfigurations for different types in a NSX domain.")]
    public class NSXTDscpIndicatorType 
    {
        /// <summary>
        /// The method for indicating the existence of INT header.
        /// </summary>
        [JsonProperty(PropertyName = "indicator_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDscpIndicatorIndicatorTypeEnumType IndicatorType { get; set; }
    }
}
