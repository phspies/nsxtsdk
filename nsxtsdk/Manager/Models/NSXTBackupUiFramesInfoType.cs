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
    public class NSXTBackupUiFramesInfoType 
    {
        /// <summary>
        /// prefix to be used for api call
        /// </summary>
        [JsonProperty(PropertyName = "api_endpoint")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBackupUiFramesInfoApiEndpointEnumType? ApiEndpoint { get; set; }
        /// <summary>
        /// Type of service, for which backup is handled
        /// </summary>
        [JsonProperty(PropertyName = "frame_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBackupUiFramesInfoFrameTypeEnumType? FrameType { get; set; }
        /// <summary>
        /// Does site have active GM
        /// </summary>
        [JsonProperty(PropertyName = "active_gm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBackupUiFramesInfoActiveGmEnumType? ActiveGm { get; set; }
        /// <summary>
        /// Version of the site
        /// </summary>
        [JsonProperty(PropertyName = "site_version")]
        public string? SiteVersion { get; set; }
        /// <summary>
        /// Id of the site
        /// </summary>
        [JsonProperty(PropertyName = "site_id")]
        public string? SiteId { get; set; }
    }
}
