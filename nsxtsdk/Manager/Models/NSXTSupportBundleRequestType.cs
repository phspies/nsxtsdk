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
    public class NSXTSupportBundleRequestType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "remote_file_server")]
        public NSXTSupportBundleRemoteFileServerType RemoteFileServer { get; set; }
        /// <summary>
        /// List of dynamic content filters that specify additional content to include in the support bundle. The list of available
        /// filters available depends on your NSX-T deployment and can be determined by invoking the GET
        /// /api/v1/adminstration/support-bundles/dynamic-content-filters NSX API. For example, if NSX Intelligence is deployed,
        /// filters for collecting specific information about services are available.
        /// </summary>
        [JsonProperty(PropertyName = "dynamic_content_filters")]
        public IList<string> DynamicContentFilters { get; set; }
        /// <summary>
        /// Bundle should include content of specified type
        /// </summary>
        [JsonProperty(PropertyName = "content_filters")]
        public IList<string> ContentFilters { get; set; }
        /// <summary>
        /// Include log files with modified times not past the age limit in days
        /// </summary>
        [JsonProperty(PropertyName = "log_age_limit")]
        public long? LogAgeLimit { get; set; }
        /// <summary>
        /// List of container clusters and their nodes requiring support bundle collection
        /// </summary>
        [JsonProperty(PropertyName = "container_nodes")]
        public IList<NSXTSupportBundleContainerNodeType> ContainerNodes { get; set; }
        /// <summary>
        /// List of cluster/fabric node UUIDs processed in specified order
        /// </summary>
        [JsonProperty(PropertyName = "nodes")]
        public IList<string> Nodes { get; set; }
    }
}
