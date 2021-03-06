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
    /// Advanced load balancer WafDataFile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer WafDataFile object")]
    public class NSXTALBWafDataFileType 
    {
        /// <summary>
        /// WAF data file type.
        /// Enum options - WAF_DATAFILE_PM_FROM_FILE, WAF_DATAFILE_DTD,
        /// WAF_DATAFILE_XSD.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as WAF_DATAFILE_PM_FROM_FILE.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbwafDataFileTypeEnumType? Type { get; set; }
        /// <summary>
        /// Stringified WAF File Data.
        /// </summary>
        [JsonProperty(PropertyName = "data", Required = Required.AllowNull)]
        public string Data { get; set; }
        /// <summary>
        /// WAF Data File Name.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
    }
}
