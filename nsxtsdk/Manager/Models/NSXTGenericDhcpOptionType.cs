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
    /// Define DHCP options other than option 121.
    /// </summary>
    [NSXTProperty(Description: @"Define DHCP options other than option 121.")]
    public class NSXTGenericDhcpOptionType 
    {
        /// <summary>
        /// Code of the dhcp option.
        /// </summary>
        [JsonProperty(PropertyName = "code", Required = Required.AllowNull)]
        public long Code { get; set; }
        /// <summary>
        /// Value of the option.
        /// </summary>
        [JsonProperty(PropertyName = "values", Required = Required.AllowNull)]
        public IList<string> Values { get; set; }
    }
}
