// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Advanced load balancer FailActionHTTPLocalResponse object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer FailActionHTTPLocalResponse object")]
    public class NSXTALBFailActionHTTPLocalResponseType 
    {
        /// <summary>
        /// Enum options - FAIL_HTTP_STATUS_CODE_200,
        /// FAIL_HTTP_STATUS_CODE_503.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as FAIL_HTTP_STATUS_CODE_503.
        /// </summary>
        public NSXTAlbfailActionHttplocalResponseStatusCodeEnumType? StatusCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTALBHTTPLocalFileType File { get; set; }
    }
}
