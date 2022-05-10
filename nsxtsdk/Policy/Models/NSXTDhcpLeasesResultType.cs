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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDhcpLeasesResultType : NSXTDhcpLeasesType
    {
        /// <summary>
        /// Policy path to Segment, Tier0 or Tier1 gateway where DHCP server
        /// is attached.
        /// </summary>
        [JsonProperty(PropertyName = "connectivity_path")]
        public string? ConnectivityPath { get; set; }
    }
}
