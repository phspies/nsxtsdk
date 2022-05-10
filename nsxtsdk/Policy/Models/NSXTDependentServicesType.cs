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
    public class NSXTDependentServicesType 
    {
        /// <summary>
        /// List of firewall dependent services.
        /// </summary>
        [JsonProperty(PropertyName = "dependent_services")]
        public IList<string> DependentServices { get; set; }
    }
}
