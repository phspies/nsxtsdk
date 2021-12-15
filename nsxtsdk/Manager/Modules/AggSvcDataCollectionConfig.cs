// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;
using System.Net;
using nsxtsdk;
using nsxtsdk.Models;
using nsxtsdk.ManagerModels;

namespace nsxtapi.ManagerModules
{
    public class AggSvcDataCollectionConfig
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public AggSvcDataCollectionConfig(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTFeatureStackCollectionConfigurationType UpdateFeatureStackConfiguration(string FeatureStackName, NSXTFeatureStackCollectionConfigurationType FeatureStackCollectionConfiguration)
        {
            if (FeatureStackName == null) { throw new System.ArgumentNullException("FeatureStackName cannot be null"); }
            if (FeatureStackCollectionConfiguration == null) { throw new System.ArgumentNullException("FeatureStackCollectionConfiguration cannot be null"); }
            NSXTFeatureStackCollectionConfigurationType returnValue = default(NSXTFeatureStackCollectionConfigurationType);
            StringBuilder UpdateFeatureStackConfigurationServiceURL = new StringBuilder("/hpm/features/{feature-stack-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateFeatureStackConfigurationServiceURL.Replace("{feature-stack-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(FeatureStackName, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(FeatureStackCollectionConfiguration, defaultSerializationSettings));
            request.Resource = UpdateFeatureStackConfigurationServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTFeatureStackCollectionConfigurationType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTFeatureStackCollectionConfigurationType GetFeatureStackConfiguration(string FeatureStackName)
        {
            if (FeatureStackName == null) { throw new System.ArgumentNullException("FeatureStackName cannot be null"); }
            NSXTFeatureStackCollectionConfigurationType returnValue = default(NSXTFeatureStackCollectionConfigurationType);
            StringBuilder GetFeatureStackConfigurationServiceURL = new StringBuilder("/hpm/features/{feature-stack-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetFeatureStackConfigurationServiceURL.Replace("{feature-stack-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(FeatureStackName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetFeatureStackConfigurationServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTFeatureStackCollectionConfigurationType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTGlobalCollectionConfigurationType UpdateAggregationServiceGlobalConfig(NSXTGlobalCollectionConfigurationType GlobalCollectionConfiguration)
        {
            if (GlobalCollectionConfiguration == null) { throw new System.ArgumentNullException("GlobalCollectionConfiguration cannot be null"); }
            NSXTGlobalCollectionConfigurationType returnValue = default(NSXTGlobalCollectionConfigurationType);
            StringBuilder UpdateAggregationServiceGlobalConfigServiceURL = new StringBuilder("/hpm/global-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(GlobalCollectionConfiguration, defaultSerializationSettings));
            request.Resource = UpdateAggregationServiceGlobalConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTGlobalCollectionConfigurationType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTGlobalCollectionConfigurationType GetAggregationServiceGlobalConfig()
        {
            NSXTGlobalCollectionConfigurationType returnValue = default(NSXTGlobalCollectionConfigurationType);
            StringBuilder GetAggregationServiceGlobalConfigServiceURL = new StringBuilder("/hpm/global-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetAggregationServiceGlobalConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTGlobalCollectionConfigurationType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTFeatureStackCollectionConfigurationType ResetAggregationServiceFeatureStackConfigurationResetCollectionFrequency(string FeatureStackName)
        {
            if (FeatureStackName == null) { throw new System.ArgumentNullException("FeatureStackName cannot be null"); }
            NSXTFeatureStackCollectionConfigurationType returnValue = default(NSXTFeatureStackCollectionConfigurationType);
            StringBuilder ResetAggregationServiceFeatureStackConfigurationResetCollectionFrequencyServiceURL = new StringBuilder("/hpm/features/{feature-stack-name}?action=reset_collection_frequency");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            ResetAggregationServiceFeatureStackConfigurationResetCollectionFrequencyServiceURL.Replace("{feature-stack-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(FeatureStackName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ResetAggregationServiceFeatureStackConfigurationResetCollectionFrequencyServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTFeatureStackCollectionConfigurationType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTFeatureStackCollectionConfigurationListType ListFeatureStackConfigurations()
        {
            NSXTFeatureStackCollectionConfigurationListType returnValue = default(NSXTFeatureStackCollectionConfigurationListType);
            StringBuilder ListFeatureStackConfigurationsServiceURL = new StringBuilder("/hpm/features");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ListFeatureStackConfigurationsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTFeatureStackCollectionConfigurationListType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}