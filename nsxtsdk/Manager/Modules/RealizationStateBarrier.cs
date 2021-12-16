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
    public class RealizationStateBarrier
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public RealizationStateBarrier(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTCurrentRealizationStateBarrierType GetCurrentBarrier()
        {
            NSXTCurrentRealizationStateBarrierType returnValue = default(NSXTCurrentRealizationStateBarrierType);
            StringBuilder GetCurrentBarrierServiceURL = new StringBuilder("/realization-state-barrier/current");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetCurrentBarrierServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetCurrentBarrierServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTCurrentRealizationStateBarrierType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTCurrentRealizationStateBarrierType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTCurrentRealizationStateBarrierType IncrementRealizationStateBarrierIncrement()
        {
            NSXTCurrentRealizationStateBarrierType returnValue = default(NSXTCurrentRealizationStateBarrierType);
            StringBuilder IncrementRealizationStateBarrierIncrementServiceURL = new StringBuilder("/realization-state-barrier/current?action=increment");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = IncrementRealizationStateBarrierIncrementServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + IncrementRealizationStateBarrierIncrementServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTCurrentRealizationStateBarrierType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTCurrentRealizationStateBarrierType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTRealizationStateBarrierConfigType UpdateRealizationStateBarrierConfig(NSXTRealizationStateBarrierConfigType RealizationStateBarrierConfig)
        {
            if (RealizationStateBarrierConfig == null) { throw new System.ArgumentNullException("RealizationStateBarrierConfig cannot be null"); }
            NSXTRealizationStateBarrierConfigType returnValue = default(NSXTRealizationStateBarrierConfigType);
            StringBuilder UpdateRealizationStateBarrierConfigServiceURL = new StringBuilder("/realization-state-barrier/config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(RealizationStateBarrierConfig, defaultSerializationSettings));
            request.Resource = UpdateRealizationStateBarrierConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + UpdateRealizationStateBarrierConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTRealizationStateBarrierConfigType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTRealizationStateBarrierConfigType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTRealizationStateBarrierConfigType GetRealizationStateBarrierConfig()
        {
            NSXTRealizationStateBarrierConfigType returnValue = default(NSXTRealizationStateBarrierConfigType);
            StringBuilder GetRealizationStateBarrierConfigServiceURL = new StringBuilder("/realization-state-barrier/config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetRealizationStateBarrierConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetRealizationStateBarrierConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTRealizationStateBarrierConfigType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTRealizationStateBarrierConfigType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
