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
    public class NSXTDhcpV6StaticBindingListResultType : NSXTListResultType
    {
        /// <summary>
        /// A paginated list of DHCP IPv6 static bindings.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTDhcpV6StaticBindingType> Results { get; set; }
    }
}
