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
    public class NSXTServiceInstanceListResultType : NSXTListResultType
    {
        /// <summary>
        /// List of the Service-Insertion ServicesInstances. The list has to be homogenous.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTBaseServiceInstanceType> Results { get; set; }
    }
}
