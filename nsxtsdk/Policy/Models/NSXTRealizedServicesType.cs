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
    public class NSXTRealizedServicesType : NSXTPolicyRealizedResourceType
    {
        /// <summary>
        /// List of realized services
        /// </summary>
        [JsonProperty(PropertyName = "realized_services")]
        public IList<NSXTRealizedServiceType> RealizedServices { get; set; }
    }
}
