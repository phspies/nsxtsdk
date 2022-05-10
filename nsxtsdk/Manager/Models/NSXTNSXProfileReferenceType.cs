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
    public class NSXTNSXProfileReferenceType : NSXTResourceReferenceType
    {
        /// <summary>
        /// Profile type of the ServiceConfig
        /// </summary>
        [JsonProperty(PropertyName = "profile_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNsxprofileReferenceProfileTypeEnumType ProfileType { get; set; }
    }
}
