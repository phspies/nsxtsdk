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
    public class License
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public License(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTLicenseType GetLicenseByKey(string LicenseKey)
        {
            if (LicenseKey == null) { throw new System.ArgumentNullException("LicenseKey cannot be null"); }
            NSXTLicenseType returnValue = default(NSXTLicenseType);
            StringBuilder GetLicenseByKeyServiceURL = new StringBuilder("/licenses/{license-key}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetLicenseByKeyServiceURL.Replace("{license-key}", System.Uri.EscapeDataString(Helpers.ConvertToString(LicenseKey, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetLicenseByKeyServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTLicenseType>(response.Content, defaultSerializationSettings);
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
        public void DeleteLicense(string LicenseKey)
        {
            if (LicenseKey == null) { throw new System.ArgumentNullException("LicenseKey cannot be null"); }
            
            StringBuilder DeleteLicenseServiceURL = new StringBuilder("/licenses/{license-key}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteLicenseServiceURL.Replace("{license-key}", System.Uri.EscapeDataString(Helpers.ConvertToString(LicenseKey, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteLicenseServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTFeatureUsageListType GetLicenseUsageReport()
        {
            NSXTFeatureUsageListType returnValue = default(NSXTFeatureUsageListType);
            StringBuilder GetLicenseUsageReportServiceURL = new StringBuilder("/licenses/licenses-usage");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetLicenseUsageReportServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTFeatureUsageListType>(response.Content, defaultSerializationSettings);
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
        public NSXTLicenseType UpdateLicense(NSXTLicenseType License)
        {
            if (License == null) { throw new System.ArgumentNullException("License cannot be null"); }
            NSXTLicenseType returnValue = default(NSXTLicenseType);
            StringBuilder UpdateLicenseServiceURL = new StringBuilder("/license");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(License, defaultSerializationSettings));
            request.Resource = UpdateLicenseServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTLicenseType>(response.Content, defaultSerializationSettings);
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
        public NSXTLicenseType GetLicense()
        {
            NSXTLicenseType returnValue = default(NSXTLicenseType);
            StringBuilder GetLicenseServiceURL = new StringBuilder("/license");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetLicenseServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTLicenseType>(response.Content, defaultSerializationSettings);
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
        public void DeleteLicenseKeyDelete(NSXTLicenseType License)
        {
            if (License == null) { throw new System.ArgumentNullException("License cannot be null"); }
            
            StringBuilder DeleteLicenseKeyDeleteServiceURL = new StringBuilder("/licenses?action=delete");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(License, defaultSerializationSettings));
            request.Resource = DeleteLicenseKeyDeleteServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTLicenseType CreateLicense(NSXTLicenseType License)
        {
            if (License == null) { throw new System.ArgumentNullException("License cannot be null"); }
            NSXTLicenseType returnValue = default(NSXTLicenseType);
            StringBuilder CreateLicenseServiceURL = new StringBuilder("/licenses");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(License, defaultSerializationSettings));
            request.Resource = CreateLicenseServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTLicenseType>(response.Content, defaultSerializationSettings);
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
        public NSXTLicensesListResultType GetLicenses()
        {
            NSXTLicensesListResultType returnValue = default(NSXTLicensesListResultType);
            StringBuilder GetLicensesServiceURL = new StringBuilder("/licenses");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetLicensesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTLicensesListResultType>(response.Content, defaultSerializationSettings);
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
        public NSXTFeatureUsageListInCsvFormatType GetLicenseUsageReportInCsvFormatCsv()
        {
            NSXTFeatureUsageListInCsvFormatType returnValue = default(NSXTFeatureUsageListInCsvFormatType);
            StringBuilder GetLicenseUsageReportInCsvFormatCsvServiceURL = new StringBuilder("/licenses/licenses-usage?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetLicenseUsageReportInCsvFormatCsvServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTFeatureUsageListInCsvFormatType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}