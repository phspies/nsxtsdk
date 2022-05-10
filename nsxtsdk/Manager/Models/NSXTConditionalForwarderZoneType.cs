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
    public class NSXTConditionalForwarderZoneType : NSXTForwarderZoneType
    {
        /// <summary>
        /// A forwarder domain name should be a valid FQDN. If reverse lookup is
        /// needed for this zone, reverse lookup domain name like X.in-addr.arpa
        /// can be defined. Here the X represents a subnet.
        /// </summary>
        [JsonProperty(PropertyName = "domain_names", Required = Required.AllowNull)]
        public IList<string> DomainNames { get; set; }
    }
}
