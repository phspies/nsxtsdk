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
    /// Software module result
    /// </summary>
    [NSXTProperty(Description: @"Software module result")]
    public class NSXTSoftwareModuleResultType 
    {
        /// <summary>
        /// Software module results
        /// </summary>
        [JsonProperty(PropertyName = "software_modules", Required = Required.AllowNull)]
        public IList<NSXTSoftwareModuleType> SoftwareModules { get; set; }
    }
}
