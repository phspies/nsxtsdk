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
    /// Reference to a CRL Distribution Point where to fetch a CRL
    /// </summary>
    [NSXTProperty(Description: @"Reference to a CRL Distribution Point where to fetch a CRL")]
    public class NSXTCrlDistributionPointStatusType 
    {
        /// <summary>
        /// Status of the fetched CRL for this CrlDistributionPoint
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTCrlDistributionPointStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Error message when fetching the CRL failed.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
    }
}
