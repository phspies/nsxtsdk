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
    public class NSXTNSServiceType : NSXTManagedResourceType
    {
        /// <summary>
        /// The default NSServices are created in the system by default. These NSServices
        /// can't be modified/deleted
        /// </summary>
        [JsonProperty(PropertyName = "default_service")]
        public bool? DefaultService { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "nsservice_element", Required = Required.AllowNull)]
        public NSXTNSServiceElementType NsserviceElement { get; set; }
    }
}
