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
        [NSXTProperty(IsRequired: false, Description: @"Error page body sent to client when match.")]
        public string? ErrorPageBody { get; set; }
        /// <summary>
        /// Format of an error page body HTML or JSON.
        /// Enum options - ERROR_PAGE_FORMAT_HTML,
        /// ERROR_PAGE_FORMAT_JSON.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as ERROR_PAGE_FORMAT_HTML.
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        [NSXTProperty(IsRequired: false, Description: @"Format of an error page body HTML or JSON.Enum options - ERROR_PAGE_FORMAT_HTML,ERROR_PAGE_FORMAT_JSON.Default value when not specified in API or module isinterpreted by ALB Controller as ERROR_PAGE_FORMAT_HTML.")]
        [NSXTDefaultProperty(Default: "ERROR_PAGE_FORMAT_HTML")]
        public NSXTAlberrorPageBodyFormatEnumType? Format { get; set; }
    }
}