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
    public class NSXTIPFIXL2CollectorProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// It accepts Multiple Collector objects.
        /// </summary>
        [JsonProperty(PropertyName = "ipfix_l2_collectors", Required = Required.AllowNull)]
        public IList<NSXTIPFIXL2CollectorType> IpfixL2Collectors { get; set; }
    }
}
