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
    /// Advanced load balancer HdrPersistenceProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HdrPersistenceProfile object")]
    public class NSXTALBHdrPersistenceProfileType 
    {
        /// <summary>
        /// Header name for custom header persistence.
        /// </summary>
        [JsonProperty(PropertyName = "prst_hdr_name")]
        public string? PrstHdrName { get; set; }
    }
}
