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
    /// This object contains list of syslog exporters used by NSX nodes.
    /// </summary>
    [NSXTProperty(Description: @"This object contains list of syslog exporters used by NSX nodes.")]
    public class NSXTSyslogPropertiesType 
    {
        /// <summary>
        /// List of syslog exporters.
        /// </summary>
        [JsonProperty(PropertyName = "exporters", Required = Required.AllowNull)]
        public IList<NSXTSyslogExporterType> Exporters { get; set; }
    }
}
