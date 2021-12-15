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
    public class NodeLogs
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public NodeLogs(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNodeLogPropertiesListResultType ListNodeLogs()
        {
            NSXTNodeLogPropertiesListResultType returnValue = default(NSXTNodeLogPropertiesListResultType);
            StringBuilder ListNodeLogsServiceURL = new StringBuilder("/node/logs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ListNodeLogsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTNodeLogPropertiesListResultType>(response.Content, defaultSerializationSettings);
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
        public NSXTNodeLogPropertiesType ReadNodeLog(string LogName)
        {
            if (LogName == null) { throw new System.ArgumentNullException("LogName cannot be null"); }
            NSXTNodeLogPropertiesType returnValue = default(NSXTNodeLogPropertiesType);
            StringBuilder ReadNodeLogServiceURL = new StringBuilder("/node/logs/{log-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadNodeLogServiceURL.Replace("{log-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadNodeLogServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTNodeLogPropertiesType>(response.Content, defaultSerializationSettings);
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
        public void ReadNodeLogData(string LogName)
        {
            if (LogName == null) { throw new System.ArgumentNullException("LogName cannot be null"); }
            
            StringBuilder ReadNodeLogDataServiceURL = new StringBuilder("/node/logs/{log-name}/data");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadNodeLogDataServiceURL.Replace("{log-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadNodeLogDataServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            
        }
    }
}