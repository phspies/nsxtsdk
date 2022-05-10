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
    public class NSXTInfraType : NSXTAbstractSpaceType
    {
        /// <summary>
        /// This field is used while creating or updating the infra space.
        /// </summary>
        [JsonProperty(PropertyName = "domains")]
        public IList<NSXTDomainType> Domains { get; set; }
    }
}
