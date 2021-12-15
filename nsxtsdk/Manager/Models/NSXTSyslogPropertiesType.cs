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
    /// This object contains list of syslog exporters used by NSX nodes.
    /// </summary>
    [NSXTProperty(Description: @"This object contains list of syslog exporters used by NSX nodes.")]
    public class NSXTSyslogPropertiesType 
    {
        /// <summary>
        /// List of syslog exporters.
        /// </summary>
        [JsonProperty(PropertyName = "exporters", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"List of syslog exporters.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTSyslogExporterType> Exporters { get; set; }
    }
}
