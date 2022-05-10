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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTMACSetType : NSXTManagedResourceType
    {
        /// <summary>
        /// MAC addresses
        /// </summary>
        [JsonProperty(PropertyName = "mac_addresses")]
        public IList<string> MacAddresses { get; set; }
    }
}
