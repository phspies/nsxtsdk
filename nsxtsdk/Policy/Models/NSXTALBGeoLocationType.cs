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
    /// Advanced load balancer GeoLocation object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer GeoLocation object")]
    public class NSXTALBGeoLocationType 
    {
        /// <summary>
        /// Latitude of the location.
        /// This is represented as degrees.minutes.
        /// The range is from -90.0 (south) to +90.0 (north).
        /// Allowed values are -90.0-+90.0.
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public double? Latitude { get; set; }
        /// <summary>
        /// Location tag string - example  USEast.
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string? Tag { get; set; }
        /// <summary>
        /// Location name in the format Country/State/City.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Longitude of the location.
        /// This is represented as degrees.minutes.
        /// The range is from -180.0 (west) to +180.0 (east).
        /// Allowed values are -180.0-+180.0.
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public double? Longitude { get; set; }
    }
}
