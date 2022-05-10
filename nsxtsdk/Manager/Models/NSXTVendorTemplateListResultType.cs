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
    public class NSXTVendorTemplateListResultType : NSXTListResultType
    {
        /// <summary>
        /// List of the Service-Insertion Services. The list has to be homogenous.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTVendorTemplateType> Results { get; set; }
    }
}
