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
    public class NSXTExtendedSolutionConfigType : NSXTManagedResourceType
    {
        /// <summary>
        /// The service to which the solution config belongs.
        /// </summary>
        [JsonProperty(PropertyName = "service_id")]
        public string? ServiceId { get; set; }
        /// <summary>
        /// List of attributes specific to a partner which needs to be passed to host.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public IList<NSXTAttributeType> Attributes { get; set; }
    }
}
