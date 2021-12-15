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
    /// Details about source and destination NSX setup to be migrated
    /// </summary>
    [NSXTProperty(Description: @"Details about source and destination NSX setup to be migrated")]
    public class NSXTMigrationSetupInfoType 
    {
        /// <summary>
        /// IP address or hostname of the destination NSX API endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "destination_nsx")]
        [NSXTProperty(IsRequired: false, Description: @"IP address or hostname of the destination NSX API endpoint.")]
        public NSXTDestinationNsxApiEndpointType DestinationNsx { get; set; }
        /// <summary>
        /// List of source NSX manager endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "source_nsx")]
        [NSXTProperty(IsRequired: false, Description: @"List of source NSX manager endpoints.")]
        public IList<NSXTSourceNsxApiEndpointType> SourceNsx { get; set; }
        /// <summary>
        /// Migration mode can be VMC_V2T, ONPREMISE_V2T, ONPREMISE_VSPHERE2T, DFW_ONLY, DFW_WITH_BRIDGED_SEG, CMP_VRA,
        /// DFW_AND_HOST_AND_WORKLOAD, DFW_AND_HOST_AND_WORKLOAD_WITH_BRIDGED_SEG, EDGE_CUTOVER
        /// </summary>
        [JsonProperty(PropertyName = "migration_mode")]
        [NSXTProperty(IsRequired: false, Description: @"Migration mode can be VMC_V2T, ONPREMISE_V2T, ONPREMISE_VSPHERE2T, DFW_ONLY, DFW_WITH_BRIDGED_SEG, CMP_VRA, DFW_AND_HOST_AND_WORKLOAD, DFW_AND_HOST_AND_WORKLOAD_WITH_BRIDGED_SEG, EDGE_CUTOVER")]
        [NSXTDefaultProperty(Default: "ONPREMISE_V2T")]
        public NSXTMigrationSetupInfoMigrationModeEnumType? MigrationMode { get; set; }
        /// <summary>
        /// Flag to indicate whether to create missing segment ports.
        /// </summary>
        [JsonProperty(PropertyName = "create_segment_ports")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to indicate whether to create missing segment ports.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? CreateSegmentPorts { get; set; }
    }
}