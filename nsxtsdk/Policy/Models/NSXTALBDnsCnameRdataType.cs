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
    /// Advanced load balancer DnsCnameRdata object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsCnameRdata object")]
    public class NSXTALBDnsCnameRdataType 
    {
        /// <summary>
        /// Canonical name.
        /// </summary>
        [JsonProperty(PropertyName = "cname", Required = Required.AllowNull)]
        public string Cname { get; set; }
    }
}
