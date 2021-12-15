// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: true, Description: @"Software module results")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTSoftwareModuleType> SoftwareModules { get; set; }
    }
}