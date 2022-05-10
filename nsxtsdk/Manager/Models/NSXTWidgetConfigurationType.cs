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
    public class NSXTWidgetConfigurationType : NSXTManagedResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "feature_set")]
        public NSXTFeatureSetType FeatureSet { get; set; }
        /// <summary>
        /// List of plotting configuration for a given widget. Widget plotting configurations which are common across all the
        /// widgets types should be define here.
        /// </summary>
        [JsonProperty(PropertyName = "plot_configs")]
        public IList<NSXTWidgetPlotConfigurationType> PlotConfigs { get; set; }
        /// <summary>
        /// Default filter values to be passed to datasources. This will be used when the report is requested without filter values.
        /// </summary>
        [JsonProperty(PropertyName = "default_filter_value")]
        public IList<NSXTDefaultFilterValueType> DefaultFilterValue { get; set; }
        /// <summary>
        /// Represents the vertical span of the widget / container. 1 Row span is equal to 20px.
        /// </summary>
        [JsonProperty(PropertyName = "rowspan")]
        public int? Rowspan { get; set; }
        /// <summary>
        /// Title of the widget. If display_name is omitted, the widget will be shown without a title.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// The 'datasources' represent the sources from which data will be fetched. Currently, only NSX-API is supported as a
        /// 'default' datasource. An example of specifying 'default' datasource along with the urls to fetch data from is given at
        /// 'example_request' section of 'CreateWidgetConfiguration' API.
        /// </summary>
        [JsonProperty(PropertyName = "datasources")]
        public IList<NSXTDatasourceType> Datasources { get; set; }
        /// <summary>
        /// Specify relavite weight in WidgetItem for placement in a view. Please see WidgetItem for details.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public int? Weight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "footer")]
        public NSXTFooterType Footer { get; set; }
        /// <summary>
        /// Please use the property 'shared' of View instead of this. The widgets of a shared view are visible to other users.
        /// </summary>
        [JsonProperty(PropertyName = "shared")]
        public bool? Shared { get; set; }
        /// <summary>
        /// Represents the horizontal span of the widget / container.
        /// </summary>
        [JsonProperty(PropertyName = "span")]
        public int? Span { get; set; }
        /// <summary>
        /// Icons to be applied at dashboard for widgets and UI elements.
        /// </summary>
        [JsonProperty(PropertyName = "icons")]
        public IList<NSXTIconType> Icons { get; set; }
        /// <summary>
        /// Set to true if this widget should be used as a drilldown.
        /// </summary>
        [JsonProperty(PropertyName = "is_drilldown")]
        public bool? IsDrilldown { get; set; }
        /// <summary>
        /// Id of filter widget for subscription, if any. Id should be a valid id of an existing filter widget. Filter widget should
        /// be from the same view. Datasource URLs should have placeholder values equal to filter alias to accept the filter value
        /// on filter change. This field is deprecated instead use 'filters' property.
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public string? Filter { get; set; }
        /// <summary>
        /// If the value of this field is set to true then card header will be displayed otherwise only card will be displayed
        /// without header.
        /// </summary>
        [JsonProperty(PropertyName = "show_header")]
        public bool? ShowHeader { get; set; }
        /// <summary>
        /// Supported visualization types are LabelValueConfiguration, DonutConfiguration, GridConfiguration, StatsConfiguration,
        /// MultiWidgetConfiguration, GraphConfiguration, ContainerConfiguration, CustomWidgetConfiguration,
        /// CustomFilterWidgetConfiguration, TimeRangeDropdownFilterWidgetConfiguration, SpacerWidgetConfiguration,
        /// LegendWidgetConfiguration and DropdownFilterWidgetConfiguration.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTWidgetConfigurationResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// A List of filter applied to this widget configuration. This will be used to identify the filters applied to this widget.
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public IList<string> Filters { get; set; }
        /// <summary>
        /// Id of drilldown widget, if any. Id should be a valid id of an existing widget. A widget is considered as drilldown
        /// widget when it is associated with any other widget and provides more detailed information about any data item from the
        /// parent widget.
        /// </summary>
        [JsonProperty(PropertyName = "drilldown_id")]
        public string? DrilldownId { get; set; }
        /// <summary>
        /// Flag to indicate that widget will continue to work without filter value. If this flag is set to false then
        /// default_filter_value is manadatory.
        /// </summary>
        [JsonProperty(PropertyName = "filter_value_required")]
        public bool? FilterValueRequired { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "legend")]
        public NSXTLegendType Legend { get; set; }
        /// <summary>
        /// If the condition is met then the widget will be displayed to UI. If no condition is provided, then the widget will be
        /// displayed unconditionally.
        /// </summary>
        [JsonProperty(PropertyName = "condition")]
        public string? Condition { get; set; }
    }
}
