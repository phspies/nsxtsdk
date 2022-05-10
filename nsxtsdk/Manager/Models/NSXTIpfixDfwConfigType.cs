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
    public class NSXTIpfixDfwConfigType : NSXTIpfixConfigType
    {
        /// <summary>
        /// This priority field is used to resolve conflicts in Logical Ports
        /// which are covered by more than one IPFIX profiles. The IPFIX
        /// exporter will send records to Collectors in highest priority
        /// profile (lowest number) only.
        /// </summary>
        [JsonProperty(PropertyName = "priority", Required = Required.AllowNull)]
        public long Priority { get; set; }
        /// <summary>
        /// Each IPFIX DFW config can have its own collector config.
        /// </summary>
        [JsonProperty(PropertyName = "collector", Required = Required.AllowNull)]
        public string Collector { get; set; }
        /// <summary>
        /// For long standing active flows, IPFIX records will be sent per timeout period
        /// </summary>
        [JsonProperty(PropertyName = "active_flow_export_timeout")]
        public long? ActiveFlowExportTimeout { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "template_parameters")]
        public NSXTIpfixDfwTemplateParametersType TemplateParameters { get; set; }
        /// <summary>
        /// An identifier that is unique to the exporting process and used to
        /// meter the Flows.
        /// </summary>
        [JsonProperty(PropertyName = "observation_domain_id", Required = Required.AllowNull)]
        public long ObservationDomainId { get; set; }
    }
}
