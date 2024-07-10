using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Api
{
 public class Reqres
    {
        private readonly RestClient client;
        private const string reqresBaseUrl = "https://reqres.in";

        public Reqres()
        {
            var options = new RestClientOptions(reqresBaseUrl);
            client = new RestClient(options);
        }
        public void ExecuteAllRequests()
        {
            GetListOfUsers();
            GetSingleUser();
            GetSingleUserNotFound();
            GetListUnknown();
            GetSingleUnknown();
            GetSingleResourcesNotFound();
            PostCreate();
            PostRegisterSuccessful();
            PostRegisterUnsuccessful();
            PostLoginSuccessful();
            PostLoginUnsuccessful();
            PutUpdate();
        }

        public void GetListOfUsers()
        {
            try
            {
                var request = new RestRequest("/api/users?page=2", Method.Get);
                RestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void GetSingleUser()
        {
            try
            {
                var request = new RestRequest("/api/users/2", Method.Get);
                RestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void GetSingleUserNotFound()
        {
            try
            {
                var request = new RestRequest("/api/users/23", Method.Get);
                RestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void GetListUnknown()
        {
            try
            {
                var request = new RestRequest("/api/unknown", Method.Get);
                RestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void GetSingleUnknown()
        {
            try
            {
                var request = new RestRequest("/api/unknown/2", Method.Get);
                RestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void GetSingleResourcesNotFound()
        {
            try
            {
                var request = new RestRequest("/api/unknown/23", Method.Get);
                RestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void PostCreate()
        {
            try
            {
                var request = new RestRequest("/api/users", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                var body = @"{
" + "\n" +
                    @"    ""name"": ""morpheus"",
" + "\n" +
                    @"    ""job"": ""leader""
" + "\n" +
                    @"}";
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void PostRegisterSuccessful()
        {
            try
            {
                var request = new RestRequest("/api/register", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                var body = @"{
" + "\n" +
                    @"    ""email"": ""eve.holt@reqres.in"",
" + "\n" +
                    @"    ""password"": ""pistol""
" + "\n" +
                    @"}";
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void PostRegisterUnsuccessful()
        {
            try
            {
                var request = new RestRequest("/api/register", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                var body = @"{
" + "\n" +
                    @"    ""email"": ""sydney@fife""
" + "\n" +
                    @"}";
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void PostLoginSuccessful()
        {
            try
            {
                var request = new RestRequest("/api/login", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                var body = @"{
" + "\n" +
                    @"    ""email"": ""eve.holt@reqres.in"",
" + "\n" +
                    @"    ""password"": ""cityslicka""
" + "\n" +
                    @"}";
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void PostLoginUnsuccessful()
        {
            try
            {
                var request = new RestRequest("/api/login", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                var body = @"{
" + "\n" +
                    @"    ""email"": ""peter@klaven""
" + "\n" +
                    @"}";
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void PutUpdate()
        {
            try
            {
                var request = new RestRequest("/api/users/2", Method.Put);
                request.AddHeader("Content-Type", "application/json");
                var body = @"{
" + "\n" +
                    @"    ""name"": ""morpheus"",
" + "\n" +
                    @"    ""job"": ""zion resident""
" + "\n" +
                    @"}";
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
