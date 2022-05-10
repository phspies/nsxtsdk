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
    public class NSXTALBErrorPageBodyType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Error page body sent to client when match.
        /// </summary>
        [JsonProperty(PropertyName = "error_page_body")]
        public string? ErrorPageBody { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Format of an error page body HTML or JSON.
        /// Enum options - ERROR_PAGE_FORMAT_HTML,
        /// ERROR_PAGE_FORMAT_JSON.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as ERROR_PAGE_FORMAT_HTML.
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlberrorPageBodyFormatEnumType? Format { get; set; }
    }
}
