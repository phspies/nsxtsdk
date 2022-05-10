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
    public class NSXTManagementConfigType : NSXTRevisionedResourceType
    {
        /// <summary>
        /// True if Management nodes publish their fqdns(instead of default IP addresses) across NSX for its reachability.
        /// </summary>
        [JsonProperty(PropertyName = "publish_fqdns", Required = Required.AllowNull)]
        public bool PublishFqdns { get; set; }
    }
}
