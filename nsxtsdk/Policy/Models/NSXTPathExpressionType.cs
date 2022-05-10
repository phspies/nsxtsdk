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
    public class NSXTPathExpressionType : NSXTExpressionType
    {
        /// <summary>
        /// This array can consist of one or more policy paths. Only policy paths of groups, segments and policy logical ports are
        /// allowed.
        /// </summary>
        [JsonProperty(PropertyName = "paths", Required = Required.AllowNull)]
        public IList<string> Paths { get; set; }
    }
}
