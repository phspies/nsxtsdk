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
    public class NSXTAutomaticHealthCheckListResultType : NSXTListResultType
    {
        /// <summary>
        /// Automatic Health Check List
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTAutomaticHealthCheckType> Results { get; set; }
    }
}
