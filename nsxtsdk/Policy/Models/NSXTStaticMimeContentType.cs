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
    public class NSXTStaticMimeContentType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// text message.
        /// </summary>
        [JsonProperty(PropertyName = "text_message", Required = Required.AllowNull)]
        public string TextMessage { get; set; }
    }
}
