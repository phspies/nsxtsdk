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
    public class NSXTStaticRouteListResultType : NSXTListResultType
    {
        /// <summary>
        /// Paginated list of static routes
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        public IList<NSXTStaticRouteType> Results { get; set; }
    }
}
