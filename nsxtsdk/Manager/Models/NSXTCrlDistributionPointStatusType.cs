// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public NSXTCrlDistributionPointStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Error message when fetching the CRL failed.
        /// </summary>
        public string? ErrorMessage { get; set; }
    }
}
