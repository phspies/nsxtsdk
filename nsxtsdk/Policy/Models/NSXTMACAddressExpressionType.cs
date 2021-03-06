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
    public class NSXTMACAddressExpressionType : NSXTExpressionType
    {
        /// <summary>
        /// This array can consist of one or more MAC addresses.
        /// </summary>
        [JsonProperty(PropertyName = "mac_addresses", Required = Required.AllowNull)]
        public IList<string> MacAddresses { get; set; }
    }
}
