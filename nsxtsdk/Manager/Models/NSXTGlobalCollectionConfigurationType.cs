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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTGlobalCollectionConfigurationType : NSXTManagedResourceType
    {
        /// <summary>
        /// The list of the locally modified feature stack data collection frequency settings.  If all feature stack data collection
        /// configurations are set to their default values, this list will be empty.
        /// </summary>
        [JsonProperty(PropertyName = "modified_feature_stack_collection_configurations")]
        [NSXTProperty(IsRequired: false, Description: @"The list of the locally modified feature stack data collection frequency settings.  If all feature stack data collection configurations are set to their default values, this list will be empty.")]
        public NSXTFeatureStackCollectionConfigurationListType ModifiedFeatureStackCollectionConfigurations { get; set; }
        /// <summary>
        /// Indicates whether data collection required by the aggregation service is enabled.  If false, no aggregation service data
        /// will be collected.  Changing this property will not affect the existing data collection frequency settings.
        /// </summary>
        [JsonProperty(PropertyName = "is_data_collection_enabled", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Indicates whether data collection required by the aggregation service is enabled.  If false, no aggregation service data will be collected.  Changing this property will not affect the existing data collection frequency settings.")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool IsDataCollectionEnabled { get; set; }
        /// <summary>
        /// The frequency in seconds at which data, which is subject to the aggregation function, is collected.
        /// </summary>
        [JsonProperty(PropertyName = "aggregated_data_collection_frequency", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The frequency in seconds at which data, which is subject to the aggregation function, is collected.")]
        //[System.ComponentModel.DataAnnotations.MinLength(60)]
        //[System.ComponentModel.DataAnnotations.MaxLength(86400)]
        [System.ComponentModel.DataAnnotations.Required]
        public long AggregatedDataCollectionFrequency { get; set; }
    }
}