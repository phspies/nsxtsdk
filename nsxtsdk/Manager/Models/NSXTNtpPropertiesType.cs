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
    /// This object contains the list of NTP servers used by NSX nodes.
    /// </summary>
    [NSXTProperty(Description: @"This object contains the list of NTP servers used by NSX nodes.")]
    public class NSXTNtpPropertiesType 
    {
        /// <summary>
        /// List of NTP servers.
        /// </summary>
        [JsonProperty(PropertyName = "servers", Required = Required.AllowNull)]
        public IList<string> Servers { get; set; }
    }
}
