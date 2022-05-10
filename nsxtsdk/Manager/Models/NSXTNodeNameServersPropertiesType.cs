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
    public class NSXTNodeNameServersPropertiesType : NSXTResourceType
    {
        /// <summary>
        /// Name servers
        /// </summary>
        [JsonProperty(PropertyName = "name_servers", Required = Required.AllowNull)]
        public IList<string> NameServers { get; set; }
    }
}
