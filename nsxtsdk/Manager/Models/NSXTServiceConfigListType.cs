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
    /// List of Service config objects that needs to be either created
        /// or updated with the respective profiles and precedence.
    /// </summary>
    [NSXTProperty(Description: @"List of Service config objects that needs to be either createdor updated with the respective profiles and precedence.")]
    public class NSXTServiceConfigListType 
    {
        /// <summary>
        /// An Array of ServiceConfig objects containing details of
        /// profiles to be applied, entities on which these profiles
        /// will be applied and precedence.
        /// </summary>
        [JsonProperty(PropertyName = "service_configs", Required = Required.AllowNull)]
        public IList<NSXTServiceConfigType> ServiceConfigs { get; set; }
    }
}
