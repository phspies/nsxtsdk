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
    /// Advanced load balancer HdrPersistenceProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HdrPersistenceProfile object")]
    public class NSXTALBHdrPersistenceProfileType 
    {
        /// <summary>
        /// Header name for custom header persistence.
        /// </summary>
        [JsonProperty(PropertyName = "prst_hdr_name")]
        [NSXTProperty(IsRequired: false, Description: @"Header name for custom header persistence.")]
        public string? PrstHdrName { get; set; }
    }
}