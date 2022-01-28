using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace WearableClientSimulation
{
    public static class Integration
    {

        public static string Pair(string requestBody)
        {
            try
            {
                var client = new RestClient("http://localhost:3000");
                var request = new RestRequest("/pair", Method.POST);
                request.AddHeader("postman-token", "ea17d475-f0ef-7bb9-3fcb-ffc83f8d84e7");
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddParameter("application/json", requestBody, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                return response.Content;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "10";
            }
            
        }

        public static string Transmit(string requestBody)
        {
            try
            {
                var client = new RestClient("http://localhost:3000");
                var request = new RestRequest("/transmit", Method.POST);
                request.AddHeader("postman-token", "ea17d475-f0ef-7bb9-3fcb-ffc83f8d84e7");
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddParameter("application/json", requestBody, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                return response.Content;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "10";
            }

        }
    }
}
