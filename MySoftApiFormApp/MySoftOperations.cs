using MySoftApiFormApp.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoftApiFormApp
{
    public class MySoftOperations
    {
        static string folderPath = @"C:\MySoft";
        static string filePath = @"C:\MySoft\connection-info.json";

        public static string GetAccessToken()
        {
            var jsonRead = File.ReadAllText(@"C:\MySoft\connection-info.json");

            if (jsonRead != "")
            {
                var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(jsonRead);

                if (IsTokenExpired(tokenResponse))
                {
                    tokenResponse = CreateAccessToken();
                }

                return tokenResponse.AccessToken;
            }
            else
            {
                var tokenResponse = CreateAccessToken();
                return tokenResponse.AccessToken;
            }
        }

        private static TokenResponse CreateAccessToken()
        {
            var client = new RestClient("https://edocumentapitest.mysoft.com.tr/oauth/token?");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("username", "{username}");
            request.AddParameter("password", "{password}");
            request.AddParameter("grant_type", "password");
            IRestResponse response = client.Execute(request);

            var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(response.Content);
            var jsonData = JsonConvert.SerializeObject(tokenResponse);
            File.WriteAllText(filePath, jsonData);

            return tokenResponse;
        }

        private static bool IsTokenExpired(TokenResponse tokenResponse)
        {
            return DateTime.Now >= tokenResponse.CreatedDate.AddSeconds(tokenResponse.ExpiresIn);
        }
    }
}
