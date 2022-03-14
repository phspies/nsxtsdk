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
    /// Advanced load balancer HTTPReselectRespCode object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPReselectRespCode object")]
    public class NSXTALBHTTPReselectRespCodeType 
    {
        /// <summary>
        /// HTTP response code ranges to match.
        /// </summary>
        public IList<NSXTALBHTTPStatusRangeType> Ranges { get; set; }
        /// <summary>
        /// HTTP response code to be matched.
        /// Allowed values are 400-599.
        /// </summary>
        public long? Codes { get; set; }
        /// <summary>
        /// Block of HTTP response codes to match for server reselect.
        /// Enum options - HTTP_RSP_4XX, HTTP_RSP_5XX.
        /// </summary>
        public IList<string> RespCodeBlock { get; set; }
    }
}
