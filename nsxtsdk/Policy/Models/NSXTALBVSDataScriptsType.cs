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
    /// Advanced load balancer VSDataScripts object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer VSDataScripts object")]
    public class NSXTALBVSDataScriptsType 
    {
        /// <summary>
        /// Index of the virtual service datascript collection.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        public long Index { get; set; }
        /// <summary>
        /// path of the virtual service datascript collection.
        /// It is a reference to an object of type VSDataScriptSet.
        /// </summary>
        [JsonProperty(PropertyName = "vs_datascript_set_path", Required = Required.AllowNull)]
        public string VsDatascriptSetPath { get; set; }
    }
}
