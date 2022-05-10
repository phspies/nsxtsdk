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
    public class NSXTDynamicContentFiltersType 
    {
        /// <summary>
        /// These filter values will be set by the remote node like the NSX Intelligence Platform for instance. We would not need to
        /// know or act on these dynamic content filters, except for passing them on as request parameters along with the support
        /// bundle collection API.
        /// </summary>
        [JsonProperty(PropertyName = "dynamic_content_filters")]
        public IList<string> DynamicContentFilters { get; set; }
    }
}
