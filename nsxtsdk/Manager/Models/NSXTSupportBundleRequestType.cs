// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSupportBundleRequestType 
    {
        /// <summary>
        /// Remote file server to copy bundles to, bundle in response body if not specified
        /// </summary>
        [JsonProperty(PropertyName = "remote_file_server")]
        [NSXTProperty(IsRequired: false, Description: @"Remote file server to copy bundles to, bundle in response body if not specified")]
        public NSXTSupportBundleRemoteFileServerType RemoteFileServer { get; set; }
        /// <summary>
        /// List of cluster/fabric node UUIDs processed in specified order
        /// </summary>
        [JsonProperty(PropertyName = "nodes", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"List of cluster/fabric node UUIDs processed in specified order")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> Nodes { get; set; }
        /// <summary>
        /// Bundle should include content of specified type
        /// </summary>
        [JsonProperty(PropertyName = "content_filters")]
        [NSXTProperty(IsRequired: false, Description: @"Bundle should include content of specified type")]
        [NSXTDefaultProperty(Default: "")]
        public IList<string> ContentFilters { get; set; }
        /// <summary>
        /// Include log files with modified times not past the age limit in days
        /// </summary>
        [JsonProperty(PropertyName = "log_age_limit")]
        [NSXTProperty(IsRequired: false, Description: @"Include log files with modified times not past the age limit in days")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        public long? LogAgeLimit { get; set; }
    }
}
