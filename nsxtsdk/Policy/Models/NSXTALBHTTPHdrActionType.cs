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
    /// Advanced load balancer HTTPHdrAction object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPHdrAction object")]
    public class NSXTALBHTTPHdrActionType 
    {
        public NSXTALBHTTPHdrActionType()
        {
        }
        /// <summary>
        /// ADD  A new header with the new value is added irrespective
        /// of the existence of an HTTP header of the given name.
        /// REPLACE  A new header with the new value is added if no
        /// header of the given name exists, else existing headers with
        /// the given name are removed and a new header with the new
        /// value is added.
        /// REMOVE  All the headers of the given name are removed.
        /// Enum options - HTTP_ADD_HDR, HTTP_REMOVE_HDR,
        /// HTTP_REPLACE_HDR.
        /// Allowed in Basic(Allowed values-
        /// HTTP_REMOVE_HDR,HTTP_REPLACE_HDR) edition,
        /// Essentials(Allowed values- HTTP_REMOVE_HDR,HTTP_REPLACE_HDR)
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"ADD  A new header with the new value is added irrespectiveof the existence of an HTTP header of the given name.REPLACE  A new header with the new value is added if noheader of the given name exists, else existing headers withthe given name are removed and a new header with the newvalue is added.REMOVE  All the headers of the given name are removed.Enum options - HTTP_ADD_HDR, HTTP_REMOVE_HDR,HTTP_REPLACE_HDR.Allowed in Basic(Allowed values-HTTP_REMOVE_HDR,HTTP_REPLACE_HDR) edition,Essentials(Allowed values- HTTP_REMOVE_HDR,HTTP_REPLACE_HDR)edition, Enterprise edition.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTAlbhttphdrActionActionEnumType Action { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "cookie")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTALBHTTPCookieDataType Cookie { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "hdr")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTALBHTTPHdrDataType Hdr { get; set; }
    }
}
