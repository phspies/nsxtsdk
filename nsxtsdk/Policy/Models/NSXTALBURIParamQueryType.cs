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
    /// Advanced load balancer URIParamQuery object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer URIParamQuery object")]
    public class NSXTALBURIParamQueryType 
    {
        /// <summary>
        /// Use or drop the query of the incoming request URI in the
        /// request URI to the backend server.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "keep_query")]
        public bool? KeepQuery { get; set; }
        /// <summary>
        /// Concatenate a string to the query of the incoming request
        /// URI and then use it in the request URI going to the backend
        /// server.
        /// </summary>
        [JsonProperty(PropertyName = "add_string")]
        public string? AddString { get; set; }
    }
}
