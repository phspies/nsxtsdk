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
    /// The DscpIndicator is the base class for global In-band network telemetry
        /// configurations for different types in a NSX domain.
    /// </summary>
    [NSXTProperty(Description: @"The DscpIndicator is the base class for global In-band network telemetryconfigurations for different types in a NSX domain.")]
    public class NSXTDscpIndicatorType 
    {
        public NSXTDscpIndicatorType()
        {
        }
        /// <summary>
        /// The method for indicating the existence of INT header.
        /// </summary>
        [JsonProperty(PropertyName = "indicator_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The method for indicating the existence of INT header.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTDscpIndicatorIndicatorTypeEnumType IndicatorType { get; set; }
    }
}