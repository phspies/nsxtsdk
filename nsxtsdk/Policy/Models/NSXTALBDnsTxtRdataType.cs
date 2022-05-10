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
    /// Advanced load balancer DnsTxtRdata object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsTxtRdata object")]
    public class NSXTALBDnsTxtRdataType 
    {
        /// <summary>
        /// Text data associated with the FQDN.
        /// </summary>
        [JsonProperty(PropertyName = "text_str", Required = Required.AllowNull)]
        public string TextStr { get; set; }
    }
}
