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
    /// Request Type to get a CRL's PEM file.
    /// </summary>
    [NSXTProperty(Description: @"Request Type to get a CRL&apos;s PEM file.")]
    public class NSXTCrlPemRequestTypeType 
    {
        /// <summary>
        /// CRL Distribution Point URI where to fetch the CRL.
        /// </summary>
        [JsonProperty(PropertyName = "cdp_uri")]
        public string? CdpUri { get; set; }
    }
}
