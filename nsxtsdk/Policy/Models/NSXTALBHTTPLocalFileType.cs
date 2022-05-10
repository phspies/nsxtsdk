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
    /// Advanced load balancer HTTPLocalFile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPLocalFile object")]
    public class NSXTALBHTTPLocalFileType 
    {
        /// <summary>
        /// File content to used in the local HTTP response body.
        /// </summary>
        [JsonProperty(PropertyName = "file_content", Required = Required.AllowNull)]
        public string FileContent { get; set; }
        /// <summary>
        /// Mime-type of the content in the file.
        /// </summary>
        [JsonProperty(PropertyName = "content_type", Required = Required.AllowNull)]
        public string ContentType { get; set; }
    }
}
