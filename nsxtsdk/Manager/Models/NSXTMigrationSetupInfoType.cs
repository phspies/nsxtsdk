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
    /// Details about source and destination NSX setup to be migrated
    /// </summary>
    [NSXTProperty(Description: @"Details about source and destination NSX setup to be migrated")]
    public class NSXTMigrationSetupInfoType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "avi_lb_endpoint")]
        public NSXTAviEndPointType AviLbEndpoint { get; set; }
        /// <summary>
        /// Comprehensive information about NSX-V multi site setup. This will be populated only when the migration is executed on a
        /// cross VC setup.
        /// </summary>
        [JsonProperty(PropertyName = "nsxv_sites")]
        public IList<NSXTSourceNsxApiEndpointType> NsxvSites { get; set; }
        /// <summary>
        /// Migration mode can be - - VMC_V2T - ONPREMISE_VSPHERE2T - ONPREMISE_V2T - CMP_VRA - FULL_MIGRATION_WITH_BYOT -
        /// FULL_MIGRATION_WITH_BYOT_ON_FEDERATION - FULL_MIGRATION_WITH_BYOT_AND_VRA -
        /// FULL_MIGRATION_WITH_BYOT_AND_VRA_ON_FEDERATION - CONFIG_MIGRATION_ONLY_WITH_BYOT -
        /// CONFIG_MIGRATION_ONLY_WITH_BYOT_ON_FEDERATION - EDGE_CUTOVER - DFW_ONLY - DFW_WITH_BRIDGED_SEG -
        /// DFW_AND_HOST_AND_WORKLOAD - DFW_AND_HOST_AND_WORKLOAD_WITH_BRIDGED_SEG
        /// </summary>
        [JsonProperty(PropertyName = "migration_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMigrationSetupInfoMigrationModeEnumType? MigrationMode { get; set; }
        /// <summary>
        /// List of mappings between NSX-T site and Avi. This will be populated only when the migration is executed on a cross VC
        /// setup.
        /// </summary>
        [JsonProperty(PropertyName = "nsxt_site_to_avi_mappings")]
        public IList<NSXTNsxtSiteToAviMappingType> NsxtSiteToAviMappings { get; set; }
        /// <summary>
        /// Mapping option can be - - UI - FILE_UPLOAD - NO_MAPPING
        /// </summary>
        [JsonProperty(PropertyName = "esg_to_router_mapping_option")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMigrationSetupInfoEsgToRouterMappingOptionEnumType? EsgToRouterMappingOption { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "destination_nsx")]
        public NSXTDestinationNsxApiEndpointType DestinationNsx { get; set; }
        /// <summary>
        /// Comprehensive information about NSX-T multi site setup. This will be populated only when the migration is executed on a
        /// cross VC setup.
        /// </summary>
        [JsonProperty(PropertyName = "nsxt_sites")]
        public IList<NSXTNsxtSiteType> NsxtSites { get; set; }
        /// <summary>
        /// List of source NSX manager endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "source_nsx")]
        public IList<NSXTSourceNsxApiEndpointType> SourceNsx { get; set; }
        /// <summary>
        /// List of site mappings between NSX-V and NSX-T. This will be populated only when the migration is executed on a cross VC
        /// setup.
        /// </summary>
        [JsonProperty(PropertyName = "v2t_site_mappings")]
        public IList<NSXTV2tSiteMappingType> V2tSiteMappings { get; set; }
        /// <summary>
        /// Flag to indicate whether to create missing segment ports
        /// </summary>
        [JsonProperty(PropertyName = "create_segment_ports")]
        public bool? CreateSegmentPorts { get; set; }
    }
}
