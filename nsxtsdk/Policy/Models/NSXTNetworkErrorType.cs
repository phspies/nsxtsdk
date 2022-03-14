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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Network error related to container objects.
    /// </summary>
    [NSXTProperty(Description: @"Network error related to container objects.")]
    public class NSXTNetworkErrorType 
    {
        /// <summary>
        /// Detailed message of network related error.
        /// </summary>
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Error code of network related error.
        /// </summary>
        public string? ErrorCode { get; set; }
        /// <summary>
        /// Additional error information in json format.
        /// </summary>
        public string? Spec { get; set; }
    }
}
